def suma_numeros(pila):
    suma=0
    for i in pila:
        suma=suma+i
    return suma
def promedio_numeros(pila):
    promedio=0
    for i in pila:
        promedio=(promedio+i)/4
    return promedio

pila=[20,20,60,80]        

print("La suma de la pila es:",suma_numeros(pila))
print("El promedio de la pila es:",promedio_numeros(pila))
