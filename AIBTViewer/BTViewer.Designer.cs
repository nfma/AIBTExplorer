﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AIBTViewer
{
    partial class BTViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.behaviorTreeView = new System.Windows.Forms.TreeView();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // behaviorTreeView
            // 
            this.behaviorTreeView.Location = new System.Drawing.Point(3, 3);
            this.behaviorTreeView.Name = "behaviorTreeView";
            this.behaviorTreeView.Size = new System.Drawing.Size(286, 463);
            this.behaviorTreeView.TabIndex = 0;
            this.behaviorTreeView.Layout += new System.Windows.Forms.LayoutEventHandler(this.behaviorTreeView_Layout);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Location = new System.Drawing.Point(-2, -1);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.behaviorTreeView);
            this.mainSplitContainer.Panel1.Layout += new System.Windows.Forms.LayoutEventHandler(this.splitContainer1_Panel1_Layout);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Size = new System.Drawing.Size(952, 471);
            this.mainSplitContainer.SplitterDistance = 316;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BTViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 508);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "BTViewer";
            this.Text = "AIBT Explorer";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.BTViewer_Layout);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView behaviorTreeView;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
