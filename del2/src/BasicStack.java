public interface Stack<T> {
    Stack<T> push(T item);
    T pop();
    T peek();
    boolean contains(T item);
    T access(T item) throws IllegalArgumentException;
    boolean isEmpty();
}

public class BasicStack implements Stack<T>{
    
    private Node first;
    
    //helper class
    private static class Node<T> {
        private T data;
        private Node<T> next;
        private Node (T t) {
            data = t;
        }
    }
    
    //initializes a stack
    public BasicStack() {
        first = null;
    }
    
    /**
     * Push an item on the top of the Stack.
     * @param item An item to put on the stack.
     * @return Itself so that you can chain pushes.
     */
    public Stack<T> push(T newItem) {
        //Prevents error if inparameter is null
        if(newItem == null) {
            throw new IllegalArgumentException();
        } 
        Node<T> n = new Node<T>(newItem); 
        if (isEmpty()){
            first = n;
        }
        else {
            n.next = first;
            first = n;
        }
    return ;
    }
    
    /**
     * Pops the topmost item of the stack.
     * @return The topmost item.
     */
    public T pop(){
        if (isEmpty()) throw new IllegalArgumentException;
        T item = first.data;        
        first = first.next;            
        return item;                   
    }

    /**
     * Returns the element on the top of the stack, but does not remove it.
     * @return The topmost element of the stack.
     */
    public T peek(){
        if (isEmpty()) throw new IllegalArgumentException;
        return first.item;
    }

    /**
     * Checks if the item is on the stack.
     * @param item The item to search for.
     * @return True if the item is found on the stack.
     */
    public boolean contains(T item){
        Node <T> n = first;
        while(n != null) {
            if(n.data = item) {
                return true;
            }
            n = n.next;
        }
        return false;
    }

    /**
     * Get the item of the stack. Will pop until it finds it of throw an IllegalArgumentException if not found.
     * @param item item to get of the stack.
     * @return Object item of the stack.
     * @throws IllegalArgumentException if item is not found
     */    
     public T access(T item) {
        if(contains(item)) {
            return item;
        }
        else {
            throw new IllegalArgumentException();
        }        
     }

    /**
     * Tests if this stack is empty. Returns true if the stack is empty, and returns false if the stack contains elements.
     * @return True if it is empty.
     */
    public boolean isEmpty()
        {
        return first == null;
        }
}



