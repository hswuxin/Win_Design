using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace _005GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text =e.X.ToString() +","+ e.Y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen p = new Pen(Color.Red, 2);
            //g.DrawLine(p,new Point(0, 0),new Point(100, 100));
            //SolidBrush b1 = new SolidBrush(Color.Blue);
            //g.FillRectangle(b1, 0, 0, 100, 100);
            //g.DrawEllipse(p, 101, 101, 100, 100);
            SolidBrush s1 = new SolidBrush(Color.Orange);
            SolidBrush s2 = new SolidBrush(Color.White);
            Color c1 = Color.FromArgb(133, 119, 119);
            Pen p1 = new Pen(c1, 1);
            //x轴偏移
            g.FillEllipse(s1, 150, 50, 100, 150);//head
            g.FillEllipse(s2, 170, 90, 20, 30);//left_eyes
            g.FillEllipse(s2, 210, 90, 20, 30);//right_eyes
            //不知名的竖线
            g.DrawLine(p1, new Point(200, 51), new Point(200, 70));//head_line
            Pen p2 = new Pen(Color.Black, 1);
            Rectangle r1 = new Rectangle(160, 128, 80, 70);
            g.DrawPie(p2, r1, 0, 180);//mouse
            g.DrawLine(p2, new Point(166, 163), new Point(166, 179));//mouth_line
            g.DrawLine(p2, new Point(176, 163), new Point(176, 190));
            g.DrawLine(p2, new Point(186, 163), new Point(186, 195));
            g.DrawLine(p2, new Point(196, 163), new Point(196, 199));
            g.DrawLine(p2, new Point(206, 163), new Point(206, 199));
            g.DrawLine(p2, new Point(216, 163), new Point(216, 195));
            g.DrawLine(p2, new Point(226, 163), new Point(226, 190));
            g.DrawLine(p2, new Point(236, 163), new Point(236, 175));
            Rectangle r2 = new Rectangle(144, 60, 114, 300);//body
            g.FillPie(s1, r2, 0, 180);
            //hand
            //0°-360°=yuan
            Rectangle r3 = new Rectangle(80, 210, 60, 60);
            g.FillPie(s1, r3, 0, 360);
            Rectangle r4 = new Rectangle(260, 210, 60, 60);
            g.FillPie(s1, r4, 0, 360);
            Rectangle r5 = new Rectangle(80, 270, 40, 40);
            g.FillPie(s1, r5, 0, 360);
            Rectangle r6 = new Rectangle(80, 310, 20, 20);
            g.FillPie(s1, r6, 0, 360);
            Rectangle r7 = new Rectangle(300, 178, 40, 40);
            g.FillPie(s1, r7, 0, 360);
            Rectangle r8 = new Rectangle(330, 163, 20, 20);
            g.FillPie(s1, r8, 0, 360);
            //leg
            Rectangle r9 = new Rectangle(332, 154, 5, 20);
            g.FillEllipse(s1, r9);//大拇指
            Rectangle r10 = new Rectangle(140, 350, 50, 50);
            g.FillEllipse(s1, r10);
            Rectangle r11 = new Rectangle(215, 350, 50, 50);
            g.FillEllipse(s1, r11);
            Rectangle r12 = new Rectangle(130, 400, 30, 30);
            g.FillEllipse(s1, r12);
            Rectangle r13 = new Rectangle(245, 400, 30, 30);
            g.FillEllipse(s1, r13);
            //foot
            Point[] pt1 = { new Point(142, 435), new Point(152, 449), new Point(108, 449) };
            g.FillPolygon(s1, pt1);
            Point[] pt2 = { new Point(262, 435), new Point(295, 449), new Point(250, 449) };
            g.FillPolygon(s1, pt2);
            //
            //
            //分隔符
            Pen s_black = new Pen(Color.Black, 1);
            g.DrawLine(s_black, new Point(400, 0), new Point(400, this.Height));
            //
            //
            //扇形偏移初始角度+要偏移的角度
            //
            //枪托
            //笔刷，黑，2px
            Pen w_black = new Pen(Color.Black, 2);
            //左1，右1，右2，左2
            Point[] pt_qt = { new Point(450, 160), new Point(570, 150), new Point(570, 180), new Point(450, 220) };
            g.DrawPolygon(w_black, pt_qt);
            //橙色笔刷
            //填充多边形
            SolidBrush main_brush = new SolidBrush(Color.FromArgb(206, 101, 54));
            Point[] pt_qt2 = { new Point(451, 161), new Point(571, 151), new Point(571, 179), new Point(451, 219) };
            g.FillPolygon(main_brush, pt_qt2);
            //枪托圆
            g.DrawEllipse(w_black, 483, 178, 10, 10);
            //填充圆
            SolidBrush white_df = new SolidBrush(Color.FromArgb(192, 184, 182));
            g.FillEllipse(white_df, 483, 178, 10, 10);

            //枪身_后部
            //左1，左2,右2,右1，中1
            Point[] pt_qs_hb = { new Point(572, 150), new Point(572, 180), new Point(732, 180), new Point(732, 135), new Point(602, 135) };
            g.DrawPolygon(w_black, pt_qs_hb);
            SolidBrush black_df=new SolidBrush(Color.FromArgb(61,61,61));
            g.FillPolygon(black_df, pt_qs_hb);

            //
            //枪身后部_圆
            g.DrawEllipse(w_black, 606, 158, 10, 10);
            g.FillEllipse(white_df, 606, 158, 10, 10);

            //枪身_前部
            //左1，左2,右2,右1
            Point[] pt_qs_qb = { new Point(734, 135), new Point(734, 180), new Point(834, 180), new Point(834, 135) };

            g.DrawPolygon(w_black, pt_qs_qb);
            g.FillPolygon(main_brush, pt_qs_qb);

            //
            //枪身前部_椭圆
            g.DrawEllipse(w_black, 769, 147, 20, 5);
            g.FillEllipse(white_df, 769, 147, 20, 5);
            //2
            g.DrawEllipse(w_black, 795, 147, 20, 5);
            g.FillEllipse(white_df, 795, 147, 20, 5);



            //中间椭圆2
            //淡色笔刷
            SolidBrush ds_brush = new SolidBrush(Color.FromArgb(225, 216, 211));
            Rectangle pt_zj_ty2 = new Rectangle(660, 140, 40, 10);
            g.FillRectangle(ds_brush, pt_zj_ty2);
            //右扇形
            g.FillPie(ds_brush, 695, 139, 10, 11, -90, 180);
            //左扇形
            g.FillPie(ds_brush, 655, 139, 10, 11, 90, 180);

            //中间椭圆
            //扇形拼接
            Rectangle pt_zj_ty = new Rectangle(705, 125, 50, 20);
            //黑色笔刷
            SolidBrush black_brush = new SolidBrush(Color.FromArgb(36, 36, 36));
            g.FillRectangle(black_brush, pt_zj_ty);
            //右扇形
            g.FillPie(black_brush, 750, 124, 10, 21, -90, 180);
            //左扇形
            g.FillPie(black_brush, 700, 124, 10, 21, 90, 180);

            //凹陷
            //橙色凸起
            g.FillPie(main_brush, 732, 171, 20, 15, 0, 180);
            //白色笔刷
            //凹陷填充
            SolidBrush white_brush = new SolidBrush(Color.White);
            g.FillPie(white_brush, 752, 174, 45, 13, -180, 180);

            //枪身枪口连接
            //左1，左2,右2,右1
            Point[] pt_lj = { new Point(834, 137), new Point(834, 178), new Point(838, 175), new Point(838, 139) };
            g.DrawPolygon(w_black, pt_lj);

            //枪口
            g.DrawLine(w_black, new Point(838, 141), new Point(888, 141));
            g.DrawLine(w_black, new Point(838, 173), new Point(908, 173));
            //竖线
            g.DrawLine(w_black, new Point(908, 173), new Point(908, 160));
            //弧形
            g.DrawArc(w_black, 886, 131, 42, 28, 90, 100);
            //
            //枪管
            Rectangle qg=new Rectangle(908, 160,80,13);//长矩形
            g.DrawRectangle(w_black, qg);
            g.DrawLine(w_black, new Point(908, 169), new Point(988, 169));//最前部中间那根
            g.DrawArc(w_black,950, 160,8,13,-90,180);
            //前端瞄具
            g.DrawLine(w_black, new Point(970, 160), new Point(970, 173));
            g.DrawLine(w_black, new Point(970, 160), new Point(970, 145));
            g.DrawLine(w_black, new Point(970, 145), new Point(960, 145));
            g.DrawArc(w_black, 950, 129, 10, 30, 0, 90);
            //
            g.DrawLine(w_black,new Point(838, 150),new Point(868,150));
            g.DrawLine(w_black, new Point(868, 150), new Point(872, 157));
            g.DrawLine(w_black, new Point(872, 157), new Point(872, 173));
            //
            //小矩形
            g.DrawRectangle(w_black, 838, 155, 5, 15);
            //
            g.DrawLine(w_black, new Point(838, 170), new Point(872, 170));
            g.DrawLine(w_black, new Point(842, 160), new Point(872, 160));
            //枪把
            g.DrawArc(w_black, 560, 180, 20, 20, -90, 90);
            g.DrawLine(w_black, new Point(580, 190), new Point(550,230));
            g.DrawArc(w_black, 550, 212, 30, 30, 90, 90);
            g.DrawLine(w_black, new Point(565, 242), new Point(604, 200));
            g.DrawLine(w_black, new Point(604, 200),new Point (605,180));
            g.DrawArc(w_black, 605, 190, 10, 15, 90, 90);
            g.DrawLine(w_black, new Point(610, 205), new Point(640, 205));
            g.DrawLine(w_black, new Point(640, 205), new Point(640, 180));
            //
            //
            //枪把圆
            g.DrawEllipse(w_black, 574, 205, 10, 10);
            g.FillEllipse(white_df, 574, 205, 10, 10);

            //

            //开火
            g.DrawArc(w_black, 607, 160, 25, 40, 90, 90);
            g.DrawArc(w_black, 612, 161, 25, 40, 100, 90);
            //shuan
            g.DrawArc(w_black, 640, 190, 15, 10, 0, 180);
            g.DrawLine(w_black, new Point(655, 195), new Point(655, 180));
            //dan jian
            g.DrawArc(w_black, 670, 117, 150, 150, 120, 70);
            g.DrawLine(w_black, new Point(708, 257), new Point(730, 230));
            g.DrawArc(w_black, 706, 138, 98, 98, 120, 70);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + "," + e.Y.ToString();

        }
    }
}
