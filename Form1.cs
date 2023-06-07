namespace Hanoi_Tower
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        public int number;
        public int numberofpucks;
        public double number_of_moves = 0;

        public int step_number = 1;
        public int step = 0;

        Stack<int> A = new Stack<int>();
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateButtons(Stack<int> aa, Stack<int> bb, Stack<int> cc)
        {
            //clear groupbox from buttons:
            // NA SZTYWNO LOKALIZACJA PRZYCISKOW !!!
            
            foreach (Control control in hanoi_groupbox.Controls)
            {
                control.Dispose();
            }
            hanoi_groupbox.Controls.Clear();

            int x = 0;
            int y = 0;
            int z = 0;

            //update A
            int[] itemsA = aa.ToArray();
            for (int i = itemsA.Length - 1; i >= 0; i--)
            {
                Button btn = new Button();
                
                switch(itemsA[i])
                {
                    case 1: btn.Size = new Size(20, 30); break;
                    case 2: btn.Size = new Size(40, 30); break;
                    case 3: btn.Size = new Size(60, 30); break;
                    case 4: btn.Size = new Size(80, 30); break;
                    case 5: btn.Size = new Size(100, 30); break;
                    case 6: btn.Size = new Size(120, 30); break;
                    case 7: btn.Size = new Size(140, 30); break;
                    case 8: btn.Size = new Size(160, 30); break;
                    case 9: btn.Size = new Size(180, 30); break;
                    case 10: btn.Size = new Size(200, 30); break;
                }
                
                //btn.Size = new Size(200 - i * 20, 30);
                btn.Location = new Point(50 + x * 10, 400 - x * 30);
                btn.BackColor = Color.Green;
                btn.Text = itemsA[i].ToString();
                btn.ForeColor = Color.Yellow; // Set the font color to red
                btn.Font = new Font(btn.Font, FontStyle.Bold); // Make the font bold
                hanoi_groupbox.Controls.Add(btn);
                x++;
            }

            //update B
            int[] itemsB = bb.ToArray();
            for (int i = itemsB.Length - 1; i >= 0; i--)
            {
                Button btn = new Button();
                switch (itemsB[i])
                {
                    case 1: btn.Size = new Size(20, 30); break;
                    case 2: btn.Size = new Size(40, 30); break;
                    case 3: btn.Size = new Size(60, 30); break;
                    case 4: btn.Size = new Size(80, 30); break;
                    case 5: btn.Size = new Size(100, 30); break;
                    case 6: btn.Size = new Size(120, 30); break;
                    case 7: btn.Size = new Size(140, 30); break;
                    case 8: btn.Size = new Size(160, 30); break;
                    case 9: btn.Size = new Size(180, 30); break;
                    case 10: btn.Size = new Size(200, 30); break;
                }
                //btn.Size = new Size(200 - i * 20, 30);
                btn.Location = new Point(300 + y * 10, 400 - y * 30);
                btn.BackColor = Color.Green;
                btn.Text = itemsB[i].ToString();
                btn.ForeColor = Color.Yellow; // Set the font color to red
                btn.Font = new Font(btn.Font, FontStyle.Bold); // Make the font bold
                hanoi_groupbox.Controls.Add(btn);
                y++;
            }

            //update C
            int[] itemsC = cc.ToArray();
            for (int i = itemsC.Length - 1; i >= 0; i--)
            {
                Button btn = new Button();
                switch (itemsC[i])
                {
                    case 1: btn.Size = new Size(20, 30); break;
                    case 2: btn.Size = new Size(40, 30); break;
                    case 3: btn.Size = new Size(60, 30); break;
                    case 4: btn.Size = new Size(80, 30); break;
                    case 5: btn.Size = new Size(100, 30); break;
                    case 6: btn.Size = new Size(120, 30); break;
                    case 7: btn.Size = new Size(140, 30); break;
                    case 8: btn.Size = new Size(160, 30); break;
                    case 9: btn.Size = new Size(180, 30); break;
                    case 10: btn.Size = new Size(200, 30); break;
                }
                //btn.Size = new Size(200 - i * 20, 30);
                btn.Location = new Point(550 + z * 10, 400 - z * 30);
                btn.BackColor = Color.Green;
                btn.Text = itemsC[i].ToString();
                btn.ForeColor = Color.Yellow; // Set the font color to red
                btn.Font = new Font(btn.Font, FontStyle.Bold); // Make the font bold
                hanoi_groupbox.Controls.Add(btn);
                z++;
            }
        }

        public void EvenAlgorithm(Stack<int> a, Stack<int> b, Stack<int> c)
        {
            int temp;

            switch (step_number)
            {
                case 1:
                    {
                        // A -> B
                        if (!b.Any())
                        {
                            temp = a.Pop();
                            b.Push(temp);
                        }
                        else //if (a.Any())
                        {
                            if(!a.Any())
                            {
                                temp = b.Pop();
                                a.Push(temp);
                                goto switch1end;
                            }
                            else if (a.Peek() < b.Peek())
                            {
                                temp = a.Pop();
                                b.Push(temp);
                            }
                            else if (a.Peek() > b.Peek())
                            {
                                temp = b.Pop();
                                a.Push(temp);
                            }
                        }
                        //----------------------------
                        //update buttons;
                        switch1end:
                        UpdateButtons(a, b, c);
                        step_number = 2;
                    }break;
                    //----------------------------
                case 2:
                    {
                        // A -> C
                        if (!c.Any())
                        {
                            temp = a.Pop();
                            c.Push(temp);
                        }
                        else //if (a.Any())
                        {
                            if (a.Peek() < c.Peek())
                            {
                                temp = a.Pop();
                                c.Push(temp);
                            }
                            else if (a.Peek() > c.Peek())
                            {
                                temp = c.Pop();
                                a.Push(temp);
                            }
                        }
                        //----------------------------
                        //update buttons;
                        UpdateButtons(a, b, c);
                        step_number = 3;
                    }break;
                //----------------------------
                case 3:
                    {
                        // B -> C
                        if (!c.Any())
                        {
                            temp = b.Pop();
                            c.Push(temp);
                        }
                        else //if (b.Any())
                        {
                            if (b.Peek() < c.Peek())
                            {
                                temp = b.Pop();
                                c.Push(temp);
                            }
                            else if (b.Peek() > c.Peek())
                            {
                                temp = c.Pop();
                                b.Push(temp);
                            }
                        }
                        //----------------------------
                        //update buttons;
                        UpdateButtons(a, b, c);
                        step_number = 1;
                        //----------------------------
                        //}
                    } break;
            }
            if (c.Count == numberofpucks)
            {
                done_label.Visible = true;
                timer1.Stop();
                return;
            }

        }

        public void OddAlgorithm(Stack<int> a, Stack<int> b, Stack<int> c)
        {       
            int temp;

            switch (step_number)
            {
                case 1:
                    {
                        // A -> C
                        if (!c.Any())
                        {
                            temp = a.Pop();
                            c.Push(temp);
                        }
                        else //if (a.Any())
                        {
                            if (a.Peek() < c.Peek())
                            {
                                temp = a.Pop();
                                c.Push(temp);
                            }
                            else if (a.Peek() > c.Peek())
                            {
                                temp = c.Pop();
                                a.Push(temp);
                            }
                        }
                        //----------------------------
                        //update buttons;
                        UpdateButtons(a, b, c);
                        step_number = 2;
                        
                    }
                    break;

                case 2:
                    {
                        // A -> B
                        if (!b.Any())
                        {
                            temp = a.Pop();
                            b.Push(temp);
                        }
                        else //if (a.Any())
                        {
                            if (!a.Any())
                            {
                                temp = b.Pop();
                                a.Push(temp);
                                goto switch1end;
                            }
                            else if (a.Peek() < b.Peek())
                            {
                                temp = a.Pop();
                                b.Push(temp);
                            }
                            else if (a.Peek() > b.Peek())
                            {
                                temp = b.Pop();
                                a.Push(temp);
                            }
                        }
                    //----------------------------
                    //update buttons;
                    switch1end:
                        UpdateButtons(a, b, c);
                        step_number = 3;
                    }
                    break;
                //----------------------------
                case 3:
                    {
                        // B -> C
                        if (!c.Any())
                        {
                            temp = b.Pop();
                            c.Push(temp);
                        }
                        else //if (b.Any())
                        {
                            if (b.Peek() < c.Peek())
                            {
                                temp = b.Pop();
                                c.Push(temp);
                            }
                            else if (b.Peek() > c.Peek())
                            {
                                temp = c.Pop();
                                b.Push(temp);
                            }
                        }
                        //----------------------------
                        //update buttons;
                        UpdateButtons(a, b, c);
                        step_number = 1;
                        //----------------------------
                        //}
                    }
                    break;
            }
            if (c.Count == numberofpucks)
            {
                done_label.Visible = true;
                timer1.Stop();
                return;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            TimeSpan elapsed = DateTime.Now - startTime;
            
            stopwatch_label.Text = string.Format("{0:00}:{1:00}:{2:000}",
                                         (int)elapsed.TotalMinutes,
                                         elapsed.Seconds,
                                         elapsed.Milliseconds);
            */

            if (numberofpucks % 2 == 0) //number is even (parzysta) -> AB -> AC -> BC
            {
                EvenAlgorithm(A, B, C);
                step++;
                moves_done_label.Text = step.ToString();
   
            }
            else //number is odd (nieparzysta) -> AC -> AB -> BC
            {
                OddAlgorithm(A, B, C);
                step++;
                moves_done_label.Text = step.ToString();
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //-------- timer --------------
            
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                startTime = DateTime.Now;
                timer1.Interval = trackBar1.Value;
                timer1.Start();
            }
            //-----------------------------
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            done_label.Visible = true;

            //clear combobox from buttons:
            foreach (Control control in hanoi_groupbox.Controls)
            {
                control.Dispose();
            }
            hanoi_groupbox.Controls.Clear();

            //pucks_combobox.SelectedItem = null;

            done_label.Visible = false;

            A.Clear();
            B.Clear();
            C.Clear();

            step = 0;
            step_number = 1;
            moves_done_label.Text = step.ToString();
        }

        private void pucks_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pucks = pucks_combobox.SelectedIndex;
            number = pucks + 2;
            numberofpucks = number;

            double moves = Math.Pow(2, number) - 1;
            moves_label.Text = moves.ToString();
            number_of_moves = moves;

            foreach (Control control in hanoi_groupbox.Controls)
            {
                control.Dispose();
            }
            hanoi_groupbox.Controls.Clear();

            int a = 0;

            for(int i = pucks + 2; i > 0; i--)
            {
                Button btn = new Button();
                switch (i)
                {
                    case 1: btn.Size = new Size(20, 30); break;
                    case 2: btn.Size = new Size(40, 30); break;
                    case 3: btn.Size = new Size(60, 30); break;
                    case 4: btn.Size = new Size(80, 30); break;
                    case 5: btn.Size = new Size(100, 30); break;
                    case 6: btn.Size = new Size(120, 30); break;
                    case 7: btn.Size = new Size(140, 30); break;
                    case 8: btn.Size = new Size(160, 30); break;
                    case 9: btn.Size = new Size(180, 30); break;
                    case 10: btn.Size = new Size(200, 30); break;
                }
                //btn.Size = new Size(200 - i * 20,30);
                btn.Location = new Point(50 + a * 10,400 - a * 30);
                btn.BackColor = Color.Green;
                btn.Text = number.ToString();
                btn.ForeColor = Color.Yellow; // Set the font color to red
                btn.Font = new Font(btn.Font, FontStyle.Bold); // Make the font bold
                hanoi_groupbox.Controls.Add(btn);

                A.Push(number); //add number of puck to the stack

                a++;
                number--;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Update the timer interval based on the trackbar value
            timer1.Interval = trackBar1.Value;
        }
    }
}