using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame_v3
{
    public partial class BadgeForm : Form
    {
        public BadgeForm()
        {
            InitializeComponent();
            this.Text = "Your Badges";
        }
        // Adds a badge to the BadgeForm
        public void AddBadge(string imagePath, string title, string description)
        {
            // Create controls for badge image and description
            PictureBox badgeImage = new PictureBox
            {
                ImageLocation = imagePath,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(100, 100),
                Margin = new Padding(10)
            };

            Label badgeLabel = new Label
            {
                Text = $"{title}\n{description}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10),
                Margin = new Padding(10)
            };

            // Add controls to the form dynamically
            FlowLayoutPanel badgePanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10)
            };

            badgePanel.Controls.Add(badgeImage);
            badgePanel.Controls.Add(badgeLabel);
            this.Controls.Add(badgePanel);
        }
    }
}
