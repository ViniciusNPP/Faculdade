package main

import( 
	"fmt"
)

func ParOuImpar(n int) (string) {
	if n % 2 == 0 {
		return "Par"
	} else {
		return "Impar"
	}
}
func SomaAte(n int) (int) {
	soma := 0
	for i := 1; i <= n; i++ {
		soma += i
	}
	return soma
}
func ClassificarNotas(nota int) string {
	switch {
	case nota >= 9 && nota <= 10:
		return "Muito Bom"
	case nota >= 7 && nota <= 8:
		return "Bom"
	case nota >= 5 && nota <= 6:
		return "Regular"
	case nota >= 3 && nota <= 4:
		return "Ruim"
	default:
		return "Muito Ruim"
	}
}

func main() {
	fmt.Println(ParOuImpar(9))
	fmt.Println(SomaAte(6))
	fmt.Println(ClassificarNotas(8));
}