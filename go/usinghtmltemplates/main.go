package main

import (
	"fmt"
	"net/http"
	"text/template"
)

const portNumber = ":8000"

func Home(w http.ResponseWriter, r *http.Request) {
	renderTemplates(w, "home.page.tmpl")
}

func Contactus(w http.ResponseWriter, r *http.Request) {
	renderTemplates(w, "contactus.page.tmpl")
}

func renderTemplates(w http.ResponseWriter, tmpl string) {
	parsedtemplate, _ := template.ParseFiles("./templates/" + tmpl)
	err := parsedtemplate.Execute(w, nil)
	if err != nil {
		fmt.Println("error parsing template : " + err.Error())
		return
	}

}

func main() {

	http.HandleFunc("/", Home)
	http.HandleFunc("/contactus", Contactus)

	_ = http.ListenAndServe(portNumber, nil)
}
