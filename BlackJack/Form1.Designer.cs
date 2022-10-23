namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LB1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.DealerCard = new System.Windows.Forms.Label();
            this.Dealer = new System.Windows.Forms.Label();
            this.PlayerCard = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.PlayerPoint = new System.Windows.Forms.Label();
            this.DealerPoint = new System.Windows.Forms.Label();
            this.PlayerAddCard = new System.Windows.Forms.Button();
            this.DealerAddCard = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.Button();
            this.Deal = new System.Windows.Forms.Button();
            this.CheckWinner = new System.Windows.Forms.Button();
            this.Remain = new System.Windows.Forms.Label();
            this.RemaingCard = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.BackColor = System.Drawing.Color.Transparent;
            this.LB1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB1.ForeColor = System.Drawing.Color.Fuchsia;
            this.LB1.Location = new System.Drawing.Point(425, 203);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(75, 37);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "莊家";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.BackColor = System.Drawing.Color.Transparent;
            this.LB2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB2.ForeColor = System.Drawing.Color.Fuchsia;
            this.LB2.Location = new System.Drawing.Point(425, 362);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(75, 37);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "玩家";
            // 
            // DealerCard
            // 
            this.DealerCard.AutoSize = true;
            this.DealerCard.BackColor = System.Drawing.Color.Gainsboro;
            this.DealerCard.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealerCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DealerCard.Location = new System.Drawing.Point(31, 42);
            this.DealerCard.Name = "DealerCard";
            this.DealerCard.Size = new System.Drawing.Size(133, 37);
            this.DealerCard.TabIndex = 2;
            this.DealerCard.Text = "莊家卡牌";
            // 
            // Dealer
            // 
            this.Dealer.AutoSize = true;
            this.Dealer.BackColor = System.Drawing.Color.Gainsboro;
            this.Dealer.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dealer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dealer.Location = new System.Drawing.Point(31, 144);
            this.Dealer.Name = "Dealer";
            this.Dealer.Size = new System.Drawing.Size(133, 37);
            this.Dealer.TabIndex = 3;
            this.Dealer.Text = "莊家點數";
            // 
            // PlayerCard
            // 
            this.PlayerCard.AutoSize = true;
            this.PlayerCard.BackColor = System.Drawing.Color.Gainsboro;
            this.PlayerCard.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerCard.Location = new System.Drawing.Point(31, 553);
            this.PlayerCard.Name = "PlayerCard";
            this.PlayerCard.Size = new System.Drawing.Size(133, 37);
            this.PlayerCard.TabIndex = 4;
            this.PlayerCard.Text = "玩家卡牌";
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.BackColor = System.Drawing.Color.Gainsboro;
            this.Player.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Player.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Player.Location = new System.Drawing.Point(31, 442);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(133, 37);
            this.Player.TabIndex = 5;
            this.Player.Text = "玩家點數";
            // 
            // PlayerPoint
            // 
            this.PlayerPoint.AutoSize = true;
            this.PlayerPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.PlayerPoint.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerPoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerPoint.Location = new System.Drawing.Point(217, 442);
            this.PlayerPoint.Name = "PlayerPoint";
            this.PlayerPoint.Size = new System.Drawing.Size(34, 37);
            this.PlayerPoint.TabIndex = 6;
            this.PlayerPoint.Text = "0";
            // 
            // DealerPoint
            // 
            this.DealerPoint.AutoSize = true;
            this.DealerPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.DealerPoint.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealerPoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DealerPoint.Location = new System.Drawing.Point(217, 144);
            this.DealerPoint.Name = "DealerPoint";
            this.DealerPoint.Size = new System.Drawing.Size(34, 37);
            this.DealerPoint.TabIndex = 7;
            this.DealerPoint.Text = "0";
            // 
            // PlayerAddCard
            // 
            this.PlayerAddCard.Enabled = false;
            this.PlayerAddCard.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerAddCard.ForeColor = System.Drawing.Color.Blue;
            this.PlayerAddCard.Location = new System.Drawing.Point(789, 362);
            this.PlayerAddCard.Name = "PlayerAddCard";
            this.PlayerAddCard.Size = new System.Drawing.Size(148, 53);
            this.PlayerAddCard.TabIndex = 8;
            this.PlayerAddCard.Text = "玩家加牌";
            this.PlayerAddCard.UseVisualStyleBackColor = true;
            this.PlayerAddCard.Click += new System.EventHandler(this.PlayerAddCard_Click);
            // 
            // DealerAddCard
            // 
            this.DealerAddCard.Enabled = false;
            this.DealerAddCard.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DealerAddCard.ForeColor = System.Drawing.Color.Green;
            this.DealerAddCard.Location = new System.Drawing.Point(789, 219);
            this.DealerAddCard.Name = "DealerAddCard";
            this.DealerAddCard.Size = new System.Drawing.Size(148, 53);
            this.DealerAddCard.TabIndex = 9;
            this.DealerAddCard.Text = "莊家加牌";
            this.DealerAddCard.UseVisualStyleBackColor = true;
            this.DealerAddCard.Click += new System.EventHandler(this.DealerAddCard_Click);
            // 
            // Pass
            // 
            this.Pass.Enabled = false;
            this.Pass.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pass.ForeColor = System.Drawing.Color.Red;
            this.Pass.Location = new System.Drawing.Point(789, 293);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(148, 53);
            this.Pass.TabIndex = 10;
            this.Pass.Text = "Pass";
            this.Pass.UseVisualStyleBackColor = true;
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // Deal
            // 
            this.Deal.Enabled = false;
            this.Deal.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Deal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deal.Location = new System.Drawing.Point(789, 434);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(148, 53);
            this.Deal.TabIndex = 11;
            this.Deal.Text = "發牌";
            this.Deal.UseVisualStyleBackColor = true;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // CheckWinner
            // 
            this.CheckWinner.Enabled = false;
            this.CheckWinner.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckWinner.ForeColor = System.Drawing.Color.Purple;
            this.CheckWinner.Location = new System.Drawing.Point(789, 136);
            this.CheckWinner.Name = "CheckWinner";
            this.CheckWinner.Size = new System.Drawing.Size(148, 53);
            this.CheckWinner.TabIndex = 12;
            this.CheckWinner.Text = "確認勝負";
            this.CheckWinner.UseVisualStyleBackColor = true;
            this.CheckWinner.Click += new System.EventHandler(this.CheckWinner_Click);
            // 
            // Remain
            // 
            this.Remain.AutoSize = true;
            this.Remain.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remain.Location = new System.Drawing.Point(394, 240);
            this.Remain.Name = "Remain";
            this.Remain.Size = new System.Drawing.Size(133, 37);
            this.Remain.TabIndex = 13;
            this.Remain.Text = "剩餘牌數";
            // 
            // RemaingCard
            // 
            this.RemaingCard.AutoSize = true;
            this.RemaingCard.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemaingCard.Location = new System.Drawing.Point(435, 301);
            this.RemaingCard.Name = "RemaingCard";
            this.RemaingCard.Size = new System.Drawing.Size(51, 37);
            this.RemaingCard.TabIndex = 14;
            this.RemaingCard.Text = "52";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Control;
            this.Start.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(789, 60);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(148, 53);
            this.Start.TabIndex = 15;
            this.Start.Text = "開啟新局";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(963, 640);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.RemaingCard);
            this.Controls.Add(this.Remain);
            this.Controls.Add(this.CheckWinner);
            this.Controls.Add(this.Deal);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.DealerAddCard);
            this.Controls.Add(this.PlayerAddCard);
            this.Controls.Add(this.DealerPoint);
            this.Controls.Add(this.PlayerPoint);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayerCard);
            this.Controls.Add(this.Dealer);
            this.Controls.Add(this.DealerCard);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Label DealerCard;
        private System.Windows.Forms.Label Dealer;
        private System.Windows.Forms.Label PlayerCard;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label PlayerPoint;
        private System.Windows.Forms.Label DealerPoint;
        private System.Windows.Forms.Button PlayerAddCard;
        private System.Windows.Forms.Button DealerAddCard;
        private System.Windows.Forms.Button Pass;
        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.Button CheckWinner;
        private System.Windows.Forms.Label Remain;
        private System.Windows.Forms.Label RemaingCard;
        private System.Windows.Forms.Button Start;
    }
}

