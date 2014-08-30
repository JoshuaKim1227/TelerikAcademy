using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade", "Grade must be a positive number.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade", "MinGrade must be a positive number.");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("minGrade, maxGrade", "MinGrade must be smaller than maxGrade.");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("comments", "Comments cannot be null or empty.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}