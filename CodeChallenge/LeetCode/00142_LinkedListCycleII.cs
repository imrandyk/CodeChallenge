using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.LeetCode
{
    partial class LeetCode
    {
        public ListNode DetectCycle(ListNode head)
        {
            // Floyd’s Cycle Finding Algorithm
            // had to google this one
            var s = head;
            var f = head;

            while (s != null && f != null && f.next != null)
            {
                s = s.next;
                f = f.next.next;
                if (s == f)
                {
                    var c = head;
                    while (c != s)
                    {
                        s = s.next;
                        c = c.next;
                    }
                    return s;
                }
            }
            return null;
        }
    }
}
