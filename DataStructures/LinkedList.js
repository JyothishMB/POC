class Node {
    constructor(val) {
        this.value = val;
        this.next = null;
    }
}

class LinkedList {
    constructor(val){
        this.head = new Node(val);
        this.tail = this.head;
        this.length = 1;
    }
    append(val) {
        const newNode = new Node(val);
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }
    prepend(val) {
        const newNode = new Node(val);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
    }
}

var MyLinkedList = new LinkedList(5);
MyLinkedList.append(10);
MyLinkedList.append(16);
MyLinkedList.prepend(25);
console.log(MyLinkedList);