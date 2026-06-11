pila=[]
def ingresar_dato (dato):
    dato=int(input("Ingrese un valor: "))
    pila.append(dato)
    print(f"El elemento ' {dato}' se inserto correctamente")
def eliminar_dato(valor):
    if len(pila)>0:
        eliminar=pila.pop()
        print(f"se ha eliminado el dato'{eliminar}'")
    else:
        print("La pila esta vacia, no hay datos")
def mostrar_pila():
    if len(pila)==0:
        print("La pila est avacia, no hay nada que mostrar")
    else:
        print("El estado actual de la pila es: ",pila)
        
        
def menu():
    while True:
        print("\n-------------Menu de pila------------")
        print("1. insertar dato a la pila")
        print("2. Eliminar dato de la pila")
        print("3. mostrar datos de la pila")
        print("4. Salir del programa")
        
        opcion=input("Seleccione la opcion:")
        if opcion== "1":
            ingresar_dato(pila)
        if opcion== "2":
            eliminar_dato(pila)
        if opcion== "3":
            mostrar_pila()
        if opcion== "4":
            break
        else:
            print("Opcion Invalida")
menu()
    