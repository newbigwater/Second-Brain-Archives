- Index
    
    01. SDI & MDI
    
    01.01. SDI
    
    01.02 MDI
    
    02. 기본 컨트롤
    
    03. 영역 나누기
    
    03.01. ToolStrip & Splitter & Panel
    
    03.02 TableLayoutPanel
    
    04. Data UI
    
    04.01 DataGridView + DataTable
    

---

# 01. SDI & MDI

> [!important]  
> SDI : Single Document InterfaceMDI : Multiple Document Interface  

## 01.01. SDI

```C#
private void Form1_Load(object sender, EventArgs e)
{
    Form[] childForms = new Form[10];
    for(int i = 0; i < 10; i++)
    {
        childForms[i] = new Form();
        childForms[i].Text = $"Child #{i + 1}";

        childForms[i].Show(); // Modaless + 현재 Form과 연관 없음
				or
				childForms[i].Show(this); // Modaless + 현재 Form과 연관 있음
    }
}
```

- childForms[i].Show();
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled.png|Untitled.png](00.%20attachments/Untitled.png)
    
      
    

- childForms[i].Show(this);
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 1.png|Untitled 1.png](00.%20attachments/Untitled%201.png)
    

## 01.02 MDI

- 창 스타일 변경
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 2.png|Untitled 2.png](00.%20attachments/Untitled%202.png)
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 3.png|Untitled 3.png](00.%20attachments/Untitled%203.png)
    

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 4.png|Untitled 4.png](00.%20attachments/Untitled%204.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 5.png|Untitled 5.png](00.%20attachments/Untitled%205.png)

```C#
private void Form1_Load(object sender, EventArgs e)
{
    Form[] childForms = new Form[10];
    for(int i = 0; i < 10; i++)
    {
        childForms[i] = new Form();
        childForms[i].Text = $"Child #{i + 1}";
        childForms[i].MdiParent = this;
        childForms[i].Show();
    }
}

private void LayoutButtonEventHandler(object sender, EventArgs e)
{
    if(sender is Button button)
    {
        switch (button.Text)
        {
            case "수평": this.LayoutMdi(MdiLayout.TileHorizontal); break;
            case "수직": this.LayoutMdi(MdiLayout.TileVertical); break;
            case "계단식": this.LayoutMdi(MdiLayout.Cascade); break;
            case "아이콘": this.LayoutMdi(MdiLayout.ArrangeIcons); break;
        }
    }
}
```

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 6.png|Untitled 6.png](00.%20attachments/Untitled%206.png)

---

# 02. 기본 컨트롤

- Resource 추가 및 PictureBox
    - 리소스 추가
        
        ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 7.png|Untitled 7.png](00.%20attachments/Untitled%207.png)
        
    - PictureBox에 적용
        
        - 기본 적용
            
            ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 8.png|Untitled 8.png](00.%20attachments/Untitled%208.png)
            
        - 특정 시점 적용
            
            ```C#
            pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rtecs;
            or
            pictureBox1.Image = Properties.Resources.rtecs;
            ```
            
        
          
        
- MenuStrip
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 9.png|Untitled 9.png](00.%20attachments/Untitled%209.png)
    
- Radio & Check Box & Group Box
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 10.png|Untitled 10.png](00.%20attachments/Untitled%2010.png)
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 11.png|Untitled 11.png](00.%20attachments/Untitled%2011.png)
    
    ![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 12.png|Untitled 12.png](00.%20attachments/Untitled%2012.png)
    
- Timer
    
    - 일정시간 간격마다 함수를 반복 호출한다.
    - 3초 마다 특정 edit box 상태 수집
    
    ```C#
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (textBox1.Text.Equals(""))
            MessageBox.Show("대기 중");
        else
            MessageBox.Show($"{textBox1.Text} 입력");
    }
    ```
    

---

# 03. 영역 나누기

## 03.01. ToolStrip & Splitter & Panel

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 13.png|Untitled 13.png](00.%20attachments/Untitled%2013.png)

## 03.02 TableLayoutPanel

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 14.png|Untitled 14.png](00.%20attachments/Untitled%2014.png)

---

# 04. Data UI

## 04.01 DataGridView + DataTable

```C#
private void Form1_Load(object sender, EventArgs e)
{
    DataTable dt = new DataTable();
    {
        DataColumn dc1 = new DataColumn();
        {
            dc1.ColumnName = "Number";
            dc1.DataType = typeof(int);
        }
        dt.Columns.Add(dc1);

        DataColumn dc2 = new DataColumn();
        {
            dc1.ColumnName = "Name";
            dc1.DataType = typeof(string);
        }
        dt.Columns.Add(dc2);

        dt.Rows.Add(1, "A");
        dt.Rows.Add(2, "B");
        dt.Rows.Add(3, "C");
        dt.Rows.Add(4, "D");
    }
    dataGridView1.DataSource = dt;
}
```

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 15.png|Untitled 15.png](00.%20attachments/Untitled%2015.png)

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 16.png|Untitled 16.png](00.%20attachments/Untitled%2016.png)

```C#
private void Form1_Load(object sender, EventArgs e)
{
    DataSet ds = new DataSet();
    {
        DataTable dt1 = new DataTable();
        {
            DataColumn dc1 = new DataColumn();
            {
                dc1.ColumnName = "Number";
                dc1.DataType = typeof(int);
            }
            dt1.Columns.Add(dc1);

            DataColumn dc2 = new DataColumn();
            {
                dc1.ColumnName = "Name";
                dc1.DataType = typeof(string);
            }
            dt1.Columns.Add(dc2);

            dt1.Rows.Add(1, "A");
            dt1.Rows.Add(2, "B");
            dt1.Rows.Add(3, "C");
            dt1.Rows.Add(4, "D");
        }
        ds.Tables.Add(dt1);

        DataTable dt2 = new DataTable();
        {
            DataColumn dc1 = new DataColumn();
            {
                dc1.ColumnName = "Number";
                dc1.DataType = typeof(int);
            }
            dt2.Columns.Add(dc1);

            DataColumn dc2 = new DataColumn();
            {
                dc1.ColumnName = "Name";
                dc1.DataType = typeof(string);
            }
            dt2.Columns.Add(dc2);

            dt2.Rows.Add(1, "A");
            dt2.Rows.Add(2, "B");
            dt2.Rows.Add(3, "C");
            dt2.Rows.Add(4, "D");
        }
        ds.Tables.Add(dt2);
    }

    dataGridView1.DataSource = ds.Tables[0];
}
```

![[Notion/Information Technology/C/it.programming.c/C 교육 자료/Lesson 05. Winform/attachments/Untitled 17.png|Untitled 17.png](00.%20attachments/Untitled%2017.png)