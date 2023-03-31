using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Linked
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        //---- 뒤에 추가
        public void prepend(LinkedList list)
        {
            next = list.first;
            list.first = this;
        }

        //---- 앞에 추가
        public void append(LinkedList list)
        {
            if (list.first == null)
            {
                list.first = this;
                this.next = null;
            }
            else
            {
                Node node = list.first;
                while (true)
                {
                    if (node.next == null) break;
                    node = node.next;
                }
                node.next = this;
                this.next = null;
            }
        }

        //---- 자기 자신 삭제
        public void delete(LinkedList list)
        {
            if (list.first == null) return;

            // 나의 앞 노드를 찾아야 함
            Node node = list.first;
            while (true)
            {
                if (node.next == this) break;
                node = node.next;
            }
            node.next = this.next;
        }

        //---- 자기 자신을 주어진 노드 뒤로 추가
        public void insertAfter(Node node, LinkedList list)
        {
            // 짜야함...
            if (list.first == null) // empty list
            {
                list.first = this;
                return;
            }
    
            Node currentNode = list.first;
            while (currentNode != null && currentNode != node)
            {
                currentNode = currentNode.next;
            }
    
            if (currentNode == null) // node not found
            {
                return;
            }
    
            this.next = currentNode.next;
            currentNode.next = this;
        }
    }

    class LinkedList
    {
        public Node first;

        public void printAll()
        {
            Node node = this.first;
            while (true)
            {
                if (node == null) break;
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
}
