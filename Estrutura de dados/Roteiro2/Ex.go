package main

import (
	"fmt"
)

type Produto struct {
	Nome string
	Preco float64
	Quantidade int
}

func main() {
	//declarando um array de inteiros com 6 posições
	array := [6]int {1,2,4,4,5,8}

	//Printando manualmente cada posição do array
	fmt.Println("indicie 1: ", array[0])
	fmt.Println("indicie 2: ", array[1])
	fmt.Println("indicie 3: ", array[2])
	fmt.Println("indicie 4: ", array[3])
	fmt.Println("indicie 5: ", array[4])
	fmt.Println("indicie 6: ", array[5])

	//Printando cada posição do array com for
	for i := 0; i < len(array); i++ {
		fmt.Println("indicie ", i+1, ": ", array[i])
	}

	//Printando cada posição com for range
	for i, v := range array {
		fmt.Println("indicie: ", i+1, " Valor: ", v)
	}
	fmt.Println("------------------------------------")
	/*
	var alunos [3][3]string

	//Preenchendo o array de alunos com for
	for i := 0; i < len(alunos); i++ {

		for j:= 0; j < len(alunos[i]); j++ {
			if j == 0 {
				fmt.Printf("Digite o indice do aluno %d: ", i+1)
				fmt.Scan(&alunos[i][j])
			}
			if j == 1 {
				fmt.Printf("Digite o RA do aluno %d: ", i+1)
				fmt.Scan(&alunos[i][j])
			}
			if j == 2 {
				fmt.Printf("Digite a nome do aluno %d: ", i+1)
				fmt.Scan(&alunos[i][j])
			}
		}
	}
	
	//Printando os dados dos alunos com for
	//\t funciona como um tab
	fmt.Println("Dados dos alunos")
	fmt.Println("-------------------------------------------------")
	fmt.Println("Índice\tRA\tNome")
	for i := 0; i < len(alunos); i++ {

		for j := 0; j < len(alunos[i]); j++ {
			fmt.Printf("%s\t", alunos[i][j])
		}
		fmt.Println()
	}
	*/
	fmt.Println("-------------------------------------------------")

	var produtos [3]Produto

	for i:= 0; i < len(produtos); i++ {
		fmt.Printf("Digite o nome do produto %d: ", i+1)
		fmt.Scan(&produtos[i].Nome)

		fmt.Printf("Digite o preço do produto %d: ", i+1)
		fmt.Scan(&produtos[i].Preco)

		fmt.Printf("Digite a quantidade do produto %d: ", i+1)
		fmt.Scan(&produtos[i].Quantidade)
	}
	fmt.Println(produtos)
}

