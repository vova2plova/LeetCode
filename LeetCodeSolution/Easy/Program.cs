using Easy.Easy_1_20;
using Easy.Easy_21_40;
using Easy.Easy_700_720;

/*var pol = new Easy_9();
Console.WriteLine(pol.IsPalindrome(-999));*/
/*
Easy_705 hs = new Easy_705();
hs.Add(155);
Console.WriteLine(hs);*/

/*Easy_13 rl = new Easy_13();
Console.WriteLine(rl.RomanToInt("III"));*/

/*Easy_14 LCP = new Easy_14();
Console.WriteLine(LCP.LongestCommonPrefix(new string[]{"a"}));*/

/*Easy_20 es = new Easy_20();
Console.WriteLine(es.IsValid("[()]"));*/

Easy_21 es = new Easy_21();
ListNode list1 = new ListNode(-9, null);
var temp1 = list1;
list1.next = new ListNode(3, null);
list1 = list1.next;
/*list1.next = new ListNode(4, null);
list1 = list1.next;*/
ListNode list2 = new ListNode(5, null);
var temp2 = list2;
list2.next = new ListNode(7, null);
list2 = list2.next;
/*list2.next = new ListNode(4, null);
list2 = list2.next;*/
/*ListNode temp1 = new ListNode(0);
ListNode temp2 = new ListNode();*/
var e1 = es.MergeTwoLists(temp1, temp2);
while (e1.next != null)
{
    Console.WriteLine(e1.val);
    e1 = e1.next;
}

