namespace Rozvrh652026;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnNacist = new System.Windows.Forms.Button();
        lblVysledek = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnNacist
        // 
        btnNacist.Location = new System.Drawing.Point(319, 25);
        btnNacist.Name = "btnNacist";
        btnNacist.Size = new System.Drawing.Size(153, 50);
        btnNacist.TabIndex = 0;
        btnNacist.Text = "Načíst body";
        btnNacist.UseVisualStyleBackColor = true;
        btnNacist.Click += btnNacist_Click;
        // 
        // lblVysledek
        // 
        lblVysledek.AutoSize = true;
        lblVysledek.Location = new System.Drawing.Point(350, 221);
        lblVysledek.Name = "lblVysledek";
        lblVysledek.Size = new System.Drawing.Size(53, 15);
        lblVysledek.TabIndex = 1;
        lblVysledek.Text = "Výsledek";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblVysledek);
        Controls.Add(btnNacist);
        Text = "Form1";
        Click += btnNacist_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblVysledek;

    private System.Windows.Forms.Button btnNacist;

    #endregion
}