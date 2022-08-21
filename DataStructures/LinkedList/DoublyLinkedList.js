//references
//https://visualgo.net/en/list

class Node {
    constructor(val) {
        this.value = val;
        this.next = null;
        this.prev = null;
    }
}

class DoublyLinkedList {
    constructor(val){
        this.head = new Node(val);
        this.tail = this.head;
        this.length = 1;
    }
    append(val) {
        const newNode = new Node(val);
        newNode.prev = this.tail;
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }
    prepend(val) {
        const newNode = new Node(val);
        this.head.prev = newNode;
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

        pre.next = newNode;
        newNode.prev = pre;

        newNode.next = after;
        after.prev = newNode;
        
        this.length++;
    }
    remove(index) {
        if(index>=this.length)
            index = this.length-1;
        let pre = this.traverseToIndex(index-1);
        let unwantednode = pre.next;
        pre.next = unwantednode.next;
        if(unwantednode.next!==null)
            unwantednode.next.prev = pre
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

var MyLinkedList = new DoublyLinkedList(5);
MyLinkedList.printList();
MyLinkedList.append(10);
MyLinkedList.printList();
MyLinkedList.append(16);
MyLinkedList.printList();
MyLinkedList.prepend(25);
MyLinkedList.printList();
MyLinkedList.insert(2,35);
MyLinkedList.printList();
MyLinkedList.remove(2);
MyLinkedList.printList();
MyLinkedList.remove(10);
MyLinkedList.printList();
//console.log(MyLinkedList);