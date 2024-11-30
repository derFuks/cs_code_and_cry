using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame_v2
{
    public partial class Form1 : Form
    {

        private List<Question> questions;
        private List<Badge> badges;
        private PlayerStats playerStats;
        private int currentQuestionIndex;
        private int score;
        private int correctAnswersInARow;

        private void Form1_Load(object sender, EventArgs e)
        {
            playerStats = new PlayerStats(); // todo: do authorization etc.
            currentQuestionIndex = 0;
            score = 0;
            correctAnswersInARow = 0;
            questions = new List<Question> // todo: get form DB + add random question selection logic
            {
                new Question("Which SQL statement is used to retrieve data from a database?", new[] { "UPDATE", "INSERT", "DELETE", "SELECT" }, 3),
                new Question("What is the color of Ishan's car?", new[] { "White", "Black", "Blue", "Red" }, 3),
                new Question("In C#, what does the keyword 'int' represent?", new[] { "Intruder", "Interface", "Integer", "Initialization" }, 2),
                new Question("Who wrote the novel 'Crime and Punishment'?", new[] { "Dostoevsky", "Tolstoy", "Emily Brontë", "Stephen King" }, 0),
                new Question("What is the primary purpose of a database index in MySQL?", new[] { "To encrypt data", "To store backup data", "To speed up data retrieval", "To connect databases" }, 2),
                new Question("In the James Bond series, what is Bond's code number?", new[] { "700", "007", "777", "070" }, 1),
                new Question("Name Ishan's favourite wine", new[] { "Zinfandel", "Montepulciano", "Syrah", "Pinot noir" }, 0),
                new Question("Name a guy from 'Game of Thrones'", new[] { "Aragorn, son of Arathorn", "Walter White", "Jon Snow", "Jane Eyre" }, 0),
                new Question("What is the return type of the 'Main' method in C#?", new[] { "int", "void", "string", "bool" }, 1),
                new Question("Who is the author of 'War and Peace'?", new[] { "Aleksandr Solzhenitsyn", "Fyodor Dostoevsky", "Leo Tolstoy", "Mikhail Bulgakov" }, 2),
                new Question("What is the primary feature of the 'WHERE' in SQL?", new[] { "Filtering rows", "Sorting rows", "Filtering grouped data", "Sorting grouped data" }, 0),
                new Question("In C#, what does 'null' represent?", new[] { "Zero", "No value", "Undefined", "Empty array" }, 1),
                new Question("Which database constraint ensures unique values in a column?", new[] { "UNIQUE", "PRIMARY KEY", "FOREIGN KEY", "CHECK" }, 0),
                new Question("Who wrote 'Jane Eyre'?", new[] { "Charlotte Brontë", "Emily Brontë", "Vasya Brontë", "Megan Brontë" }, 0),
                new Question("Which SQL function is used to count the number of rows in a table?", new[] { "TOTAL()", "COUNT()", "GETROWS()", "GETTOTAL()" }, 1),
                new Question("What is a 'deadlock' in database systems?", new[] { "A situation where two transactions block each other", "An error in SQL syntax", "An infinite loop", "A memory leak" }, 0),
                new Question("What would fit a 2 liter can?", new[] { "Microwave oven", "Carburetor", "German Shepherd", "Hamburger" }, 3),
                new Question("What is the purpose of the 'Group By' clause in SQL?", new[] { "To aggregate data", "To sort data", "To filter data", "To join tables" }, 0),
                new Question("Which James Bond movie features the villain Goldfinger?", new[] { "Goldfinger", "Dr. No", "Skyfall", "Casino Royale" }, 0),
                new Question("Which SQL clause is used to remove duplicates from a result set?", new[] { "DISTINCT", "GROUP BY", "UNIQUE", "FILTER" }, 0),
                new Question("Who played Walter White in 'Breaking Bad'?", new[] { "Bryan Cranston", "Aaron Paul", "Dean Norris", "Bob Odenkirk" }, 0),
                new Question("What does the keyword 'static' mean in C#?", new[] { "Is a constant", "Cannot be inherited", "Belongs to the class", "Is a variable" }, 2),
                new Question("Which Stephen King novel features a telekinetic prom queen?", new[] { "It", "Carrie", "The Shining", "Misery" }, 1),
                new Question("What does the 'HAVING' clause in SQL do?", new[] { "Filters rows", "Joins tables", "Sorts data", "Filters grouped data" }, 0),
                new Question("What is the maximum value of an INT in MySQL?", new[] { "2,147,483,647", "1,213,000,044", "4,294,967,295", "9,223,372,036,854,775,807" }, 0),
            };

            // some achievements in for of badges
            badges = new List<Badge>
            {
                new Badge("Beginner", "Nice to meet you!", "images/beginner.png"), // for starting a game
                new Badge("Looser","Failed for the first time","images/looser.png"), // for loosing for the 5th time
                new Badge("Explorer","Nothing will stop you. Keep going!","images/explorer.png"), // for playing for the 3 time
                new Badge("Cyborg","What are you?!","images/cyborg.png"), //for starting a game after 3 failures
                new Badge("Maniac","You are playing over 10 times. Are you ok?","images/maniac.png"), // for playing over 10 times
                new Badge("Cheater","You can't know it all","images/cheater.png"), //for answering 10 questions without loosing
            };

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.QuestionText;
                btnOption1.Text = question.Options[0];
                btnOption2.Text = question.Options[1];
                btnOption3.Text = question.Options[2];
                btnOption4.Text = question.Options[3];
            }
            else
            {
                MessageBox.Show("No more questions. Your a fu%king genius!");
                Application.Exit();
            }
        }

        private void btnOption1_Click(object sender, EventArgs e) => CheckAnswer(0);
        private void btnOption2_Click(object sender, EventArgs e) => CheckAnswer(1);
        private void btnOption3_Click(object sender, EventArgs e) => CheckAnswer(2);
        private void btnOption4_Click(object sender, EventArgs e) => CheckAnswer(3);

        private void CheckAnswer(int selectedOptionIndex)
        {
            var question = questions[currentQuestionIndex];
            if(selectedOptionIndex == question.CorrectOptionIndex)
            {
                correctAnswersInARow++;
                score += 1; // todo: make more complex logic
                if (correctAnswersInARow == 7)
                {
                    MessageBox.Show($"You win $5000. Damn good!");
                    UpdatePlayerStats(true, 5000);
                    return;
                }

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Ouch.. Wrong answer. You can do better!");
                UpdatePlayerStats(false, 0);
            }
        }

        private void UpdatePlayerStats(bool won, int earnings)
        {
            playerStats.TotalGamesPlayed++;
            if (won)
            {
                playerStats.TotalGamesWon++;
                playerStats.TotalEarnings += earnings;
                playerStats.ConsecutiveLosses = 0;
            }
            else {
                playerStats.TotalGamesLost++;
                playerStats.ConsecutiveLosses++;
            }

            //ShowBadges();
            MessageBox.Show("Stats updated");
        }
        //private void ShowBadges()
        //{
        //    BadgeForm badgeForm = new BadgeForm();
        //    foreach(var badge in badges)
        //    {
        //        if (badge.IsEarned)
        //        {
        //            badgeForm.AddBadge(badge.ImagePath, badge.Title, badge.Description);
        //        }
        //    }
        //    badgeForm.Show();
        //}
    }
}
