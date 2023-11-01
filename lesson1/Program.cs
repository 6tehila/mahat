using lesson1;
using System.Net.Http.Headers;
using System.Xml.Linq;

static Node<int> AddStart(Node<int> head, int value) => new Node<int>(value, head);
//{//הוספת איבר חדש וחיבורו לתחילת הרשימה הקימת
//במקרה של הרשימה הריקה  המצביע של תחילת הרשימה מכיל null
//    if(head == null)
//        return new Node<int>(value);//החזרת איבר ראשון חדש 
//    return new Node<int>(value, head);
//}
static Node<int> AddEnd(Node<int> head, int value)
{
    Node<int> temp;
    if (head == null)//אם הרשימה ריקה תוסיף איבר בתחילת הרשימה 
        return AddStart(head, value);
    //לולאה ללא גוף שסורקת את הרשימה עד האיבר האחרון שם הי אנעצרת 
    for (temp = head; temp.HasNext(); temp = temp.GetNext()) ;
    temp.SetNext(new Node<int>(value));
    return head;
}
static void Print(Node<int> head)
{
    for (; head != null; Console.Write(head.GetValue() + " "), head = head.GetNext()) ;
}

//2 הדפסת רשימה מקושרת הפוך 
static void PrintRevers(Node<int> head)
{
    if (head == null)
        return;
    PrintRevers(head.GetNext());
    /*Console.Write(head + " ");*///.GetValue()
}

Node<int> head = null;//= new Node<int>(1);
//Node<int> item1 = new Node<int>(2);
//Node<int> item2 = new Node<int>(3);
//Node<int> item3 = new Node<int>(4);
//Node<int> item4 = new Node<int>(5);
//head.SetNext(item1);
//item1.SetNext(item2);
//item2.SetNext(item3);
//item3.SetNext(item4);
for (int i = 0; i < 10; i++)
{
    head = AddEnd(head, i - 5);
}
//Print(head);

//Console.WriteLine();
//PrintRevers(head);

//3
static int Count(Node<int> head)
{
    int count = 0;
    while (head != null)
    {
        count++;
        head = head.GetNext();
    }
    return count;
}
//Console.WriteLine();
//Console.WriteLine("count: " + Count(head));
//4
////static Node<int> RemoveNegative(Node<int> head)
////    {
////    Node<int> dummy = new Node<int>(0); // צומת דמי לשמירה על הראש
////    dummy.SetNext(head);
////    Node<int> current = dummy;

////    while (current.GetNext() != null)
////    {
////        if (current.GetNext().GetValue() < 0)
////        {
////            current.SetNext(current.GetNext().GetNext()); // מחיקת הצומת הנוכחית
////        }
////        else
////        {
////            current = current.GetNext();
////        }
////    }
////    return dummy.GetNext(); // מחזירים את הרשומה לאחר המחיקות
////}
RemoveNegative(head);
Print(head);
static Node<int> RemoveNegative(Node<int> head)
{
    while (head.GetNext() != null)
    {
        if (head.GetNext().GetValue() < 0)
        {
            head.SetNext(head.GetNext().GetNext());
        }
        head = head.GetNext();
    }
    return head;
}


