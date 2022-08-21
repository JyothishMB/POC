//references
//https://visualgo.net/en/list

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
    printList() {
        let valueArray = [];
        let currentNode = this.head;
        while(currentNode!==null){
            valueArray.push(currentNode.value);
            currentNode = currentNode.next;
        }
        console.log(valueArray);
    }
    insert(index, val) {
        if(index>=this.length){
            return this.append(val);
        }
        let pre = this.traverseToIndex(index - 1);
        let after = pre.next;
        const newNode = new Node(val);
        newNode.next = after;
        pre.next = newNode;
        this.length++;
    }
    remove(index) {
        let pre = this.traverseToIndex(index-1);
        let unwantednode = pre.next;
        pre.next = unwantednode.next;
        this.length--;

    }
    traverseToIndex(index) {
        let pre = this.head;
        for(let i=0;i<index;i++){
            pre = pre.next;
        }
        return pre;
    }
}

var MyLinkedList = new LinkedList(5);
MyLinkedList.append(10);
MyLinkedList.append(16);
MyLinkedList.prepend(25);
MyLinkedList.insert(2,35);
MyLinkedList.printList();
MyLinkedList.remove(2);
MyLinkedList.printList();
console.log(MyLinkedList);