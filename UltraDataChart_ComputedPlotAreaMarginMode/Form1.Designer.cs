
namespace UltraDataChart_ComputedPlotAreaMarginMode
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ultraDataChart1 = new Infragistics.Win.DataVisualization.UltraDataChart();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraDataChart1
            // 
            this.ultraDataChart1.BackColor = System.Drawing.Color.White;
            this.ultraDataChart1.CrosshairPoint = new Infragistics.Win.DataVisualization.Point(double.NaN, double.NaN);
            this.ultraDataChart1.HorizontalViewScrollbarCornerRadius = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarHeight = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarInset = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarMaxOpacity = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarShouldAddAutoTrackInsets = true;
            this.ultraDataChart1.HorizontalViewScrollbarStrokeThickness = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarTrackEndInset = double.NaN;
            this.ultraDataChart1.HorizontalViewScrollbarTrackStartInset = double.NaN;
            this.ultraDataChart1.Location = new System.Drawing.Point(13, 13);
            this.ultraDataChart1.MarkerBrushes.Add(new Infragistics.Win.DataVisualization.SolidColorBrush(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))));
            this.ultraDataChart1.Name = "ultraDataChart1";
            this.ultraDataChart1.ScrollbarsAnimationDuration = 300;
            this.ultraDataChart1.Size = new System.Drawing.Size(621, 425);
            this.ultraDataChart1.TabIndex = 0;
            this.ultraDataChart1.Text = "ultraDataChart1";
            this.ultraDataChart1.VerticalViewScrollbarCornerRadius = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarInset = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarMaxOpacity = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarShouldAddAutoTrackInsets = true;
            this.ultraDataChart1.VerticalViewScrollbarStrokeThickness = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarTrackEndInset = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarTrackStartInset = double.NaN;
            this.ultraDataChart1.VerticalViewScrollbarWidth = double.NaN;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 451);
            this.Controls.Add(this.ultraDataChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.DataVisualization.UltraDataChart ultraDataChart1;
    }
}

