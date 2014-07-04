using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Score must be between 1 and 99");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.score, 0, 100, "Exam results calculated by score.");
    }
}
