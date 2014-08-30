using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new HTMLElement(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new HTMLElement(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new HTMLTable(rows, cols);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public class HTMLElement : IElement
    {
        private string name;
        private string textContent;
        protected List<IElement> childElements = new List<IElement>();

        public HTMLElement(string name)
        {
            this.name = name;
        }

        public HTMLElement(string name, string textContent)
        {
            this.name = name;
            this.textContent = textContent;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<");
                output.Append(this.Name);
                output.Append(">");
            }

            if (this.TextContent != null)
            {
                output.Append(this.EncodeToHTML(this.TextContent));
            }

            foreach (IElement element in childElements)
            {
                element.Render(output);
            }

            if (this.Name != null)
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append(">");
            }
        }

        public string EncodeToHTML(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (var ch in text)
            {
                if (ch == '<')
                {
                    result.Append("&lt;");
                }
                else if (ch == '>')
                {
                    result.Append("&gt;");
                }
                else if (ch == '&')
                {
                    result.Append("&amp;");
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        public override string ToString() // <(name)>(text_content)(child_content)</(name)>
        {
            StringBuilder StrBuilder = new StringBuilder();
            this.Render(StrBuilder);
            return StrBuilder.ToString();
        }
    }

    public class HTMLTable : HTMLElement, ITable
    {
        private int rows;
        private int cols;
        private HTMLElement[,] tableContent;

        public HTMLTable(int rows, int cols)
            : base("table")
        {
            this.rows = rows;
            this.cols = cols;

            this.tableContent = new HTMLElement[this.rows, this.cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableContent[row, col];
            }
            set
            {
                this.tableContent[row, col] = value as HTMLElement;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int row = 0; row < this.tableContent.GetLength(0); row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.tableContent.GetLength(1); col++)
                {
                    output.Append("<td>");

                    this.tableContent[row, col].Render(output);

                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }
    }
}