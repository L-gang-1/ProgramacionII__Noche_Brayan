#Escriba un programa que pida al usuario numeros reales hasta que ingrese un numero negativo.
#Calcula el promedio de los numeros ingresados pero solo considera los numeros que sean mayores o iguales a 10:
#Y al final si no ingresaron numeros validos que muestre un mensaje "no se calculo el promedio".
Numeros_mayores_a_10=0
suma_mayores_a_10=0
suma_de_numeros_mayores_a_10=0
Promedio=0
a=0
while a>=0:
    a=int(input("Ingrese el numero real:\n"))
    if a>10:
        suma_mayores_a_10=suma_mayores_a_10+1
        suma_de_numeros_mayores_a_10=suma_de_numeros_mayores_a_10+a
        Promedio=suma_de_numeros_mayores_a_10/suma_mayores_a_10
if Promedio==0:
    print("NO SE PUDO CACULAR EL PROMEDIO")
else:
    print("El promedio de numeros mayores a 10 es:",Promedio)