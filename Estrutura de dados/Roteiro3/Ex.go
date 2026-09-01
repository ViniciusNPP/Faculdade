package main

import (
	"fmt"
)

func Swap(a, b *int){
	var t = *a
	*a = *b
	*b = t
}

//Cria a estrutura de nós
type Task struct {
	data string
	next *Task
}
//Cria a lista encadeada
type TaskList struct {
	head *Task
}
//Adiciona um nó a lista encadeada
func (t *TaskList) AddTask(data string) {
	newTask := &Task{data: data}
	if t.head == nil {
		t.head = newTask
		return
	}
	current := t.head
	for current.next != nil {
		current = current.next
	}
	current.next = newTask
}
//Remove o nó da lista encadeada
func (t *TaskList) CompleteTask() {
	if t.head != nil {
		t.head = t.head.next
	}
}
//Printa as tarefas da lista encadeada
func (t *TaskList) ShowTasks() {
	current := t.head
	for current != nil {
		fmt.Println(current.data)
		current = current.next
	}
}

func main() {
	var b float64 = 32.5
	var p2 *float64 = &b

	*p2 = 62.5
	fmt.Printf("Valor de b: %f\n", *p2)
	fmt.Println("------------------------------------")

	x,y := 10,20

	fmt.Printf(("Antes do Swap:\nx = %d\ny = %d\n"), x, y)
	Swap(&x,&y)
	fmt.Printf(("Depois do Swap:\nx = %d\ny = %d\n"), x, y)
	fmt.Println("------------------------------------")

	lista := TaskList{}
	// Adicionando tarefas
	lista.AddTask("Estudar Go")
	lista.AddTask("Fazer compras")
	lista.AddTask("Academia")

	lista.ShowTasks()
	lista.CompleteTask() //Remove a primeira tarefa
	fmt.Println("------------------")

	lista.ShowTasks() 
	lista.CompleteTask() //Remove a segunda tarefa
	fmt.Println("------------------")

	lista.ShowTasks()
	fmt.Println("------------------------------------")
}