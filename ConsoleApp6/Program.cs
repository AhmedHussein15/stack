#include <iostream>

using namespace std;


struct node
{
    int data;
    node* next;
};


node* head = NULL;


void insertNode(int value);
void Display();
void insert_beg(int value);
void Delete_beg();
void peak();

int main()
{
    insertNode(10);
    insertNode(20);
    insertNode(30);
    insertNode(40);
    Display();
    insert_beg(34);
    Display();
    Delete_beg();
    Display();
    peak();
    Display();


    return 0;
}


void insertNode(int value)
{
    node* new_node,*last;
    new_node = new node;
    new_node->data = value;
    if (head == NULL)
    {
        head = new_node;
        new_node->next = NULL;
    }
    else
    {
        last = head;
        while (last->next != NULL)
        {
            last = last->next;
        }
        last->next = new_node;
        new_node->next = NULL;


    }

}

void Display()
{
    node* current_node;
    if (head == NULL)
    {
        cout << "linked list is empty";
    }
    else
    {
        current_node = head;
        while (current_node != NULL)
        {
            cout << current_node->data << "\t";
            current_node = current_node->next;
        }
    }
    cout << endl;
}


void insert_beg(int value)
{
    node* new_node = new node;
    new_node->data = value;
    new_node->next = head;
    head = new_node;
}

void Delete_beg()
{
    if (head == NULL)
    {
        cout << "linked list is Empty : ";
    }
    else
    {
        node* first_node = head;
        head = first_node->next;
        delete(first_node);



    }
}

void peak()
{
    if (head == NULL)
    {
        cout << "linked list is empty.";
    }
    else if (head->next == NULL)
    {
        cout << "linked list is empty.";
    }
    else
    {
        node* ptr = head;
        while (ptr->next->next != NULL)
        {
            ptr = ptr->next;
        }
        delete(ptr->next);
        ptr->next = NULL;
    }
}
