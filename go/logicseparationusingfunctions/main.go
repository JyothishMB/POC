package main

import (
	"errors"
	"fmt"
	"net/http"
)

const portNumber = ":8000"

func Home(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "This is a my home page")
}

func Contactus(w http.ResponseWriter, r *http.Request) {
	sum := addValues(2, 4)
	fmt.Fprintf(w, fmt.Sprintf("This is a my Contact Us page and 2+4 is %d", sum))
}

func DevideValues(w http.ResponseWriter, r *http.Request) {
	res, err := devide(4, 0)
	if err != nil {
		fmt.Fprintf(w, err.Error())
		return
	}
	fmt.Fprintf(w, fmt.Sprintf("4/2 is %f", res))
}

func devide(x, y float32) (float32, error) {
	if y <= 0 {
		err := errors.New("Division by zero is not allowed")
		return 0, err
	}
	result := x / y
	return result, nil
}

// addValues is a method which takes tow integers and return their sum as integer
// This is a private method.
// This can be created using a function name with first letter lowercase
func addValues(x, y int) int {
	var sum int
	sum = x + y
	return sum
}

func main() {

	http.HandleFunc("/", Home)
	http.HandleFunc("/contactus", Contactus)
	http.HandleFunc("/devide", DevideValues)

	_ = http.ListenAndServe(portNumber, nil)
}
