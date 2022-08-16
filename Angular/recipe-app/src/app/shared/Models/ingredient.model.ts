export class Ingredient {
    constructor(public name: string, public amount: number){
        //no need to explicitly create varibles. 
        //If we specify access specifiers in constructor parameters, 
        //TS will create the variables behind the scenes.
    }
}