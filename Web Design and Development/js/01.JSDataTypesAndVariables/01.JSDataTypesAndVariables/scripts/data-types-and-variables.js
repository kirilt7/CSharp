// ex.01 Assign all the possible JavaScript literals to different variables.
var intLit = 5;
var stringLit = 'Pesho';
var arrayLit = [1, 2, 3];
var boolLit = true;
var objLit = {
    name: 'Pesho',
    age:'23'
}
var funcLit = 
    alert('Hello world!');

console.log(intLit + ' ' + stringLit + ' ' + arrayLit + ' ' + boolLit + ' ' + objLit + ' ' + funcLit);

// ex.02 Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.
var exampleString = '"How you doin\'?", Joey said.';
console.log(exampleString);

// ex.03 Try typeof on all variables you created.
console.log(typeof intLit);
console.log(typeof stringLit);
console.log(typeof arrayLit);
console.log(typeof boolLit);
console.log(typeof objLit);
console.log(typeof funcLit);
console.log(typeof exampleString);

// ex.04 Create null, undefined variables and try typeof on them.
var nullVaviable = null;
var undefinedVariable = undefined;
console.log(nullVaviable);
console.log(undefinedVariable);