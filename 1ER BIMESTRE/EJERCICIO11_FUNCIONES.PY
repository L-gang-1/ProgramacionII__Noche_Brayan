def sumar (a,b):
    return a+b
def restar (a,b):
    return a-b
def multiplicacion (a,b):
    return a*b
def division (a,b):
    if b==0:
        return "Error: no se puede dividir entre 0"
    return a/b

def calculadora ():
    print("CALCULADORA BASICA")
    print("1.- SUMAR")
    print("2.- RESTAR")
    print("3.- MULTIPLICACION")
    print("4.- DIVIDIR")

    opcion=(input("Ingrese una opcion: "))
    if opcion=="1":
        a=float(input("Ingrese el primer numero: "))
        b=float(input("Ingrese el segundo numero: "))
        print("La suma es:",sumar(a,b))
    elif opcion=="2":
        a=float(input("Ingrese el primer numero: "))
        b=float(input("Ingrese el segundo numero: "))
        print("La resta es:",restar(a,b))
    elif opcion=="3":
        a=float(input("Ingrese el primer numero: "))
        b=float(input("Ingrese el segundo numero: "))
        print("La multiplicacion es:",multiplicacion(a,b))
    elif opcion=="4":
        a=float(input("Ingrese el primer numero: "))
        b=float(input("Ingrese el segundo numero: "))
        print("La divicion es:",division(a,b))

calculadora()
    
    