#SACAR EL PROMEDIO DE NOTAS CON FUNCIONES
def sumar_notas(pila_notas):
    sumar_total=0
    cantidad=0
    for nota in pila_notas:
        sumar_total=sumar_total+nota
        cantidad=cantidad+1
    return sumar_total,cantidad
def promedio_notas(pila_notas):
    suma,cantidad=sumar_notas(pila_notas)
    if cantidad==0:
        return 0
    return suma/cantidad

pila_notas=[]
cantidad_notas=int(input("Ingrese la cantidad de notas: "))
for i in range(cantidad_notas):
    notas=float(input("Ingrese la nota: "))
    pila_notas.append(notas)

suma,cant=sumar_notas(pila_notas)
print("LOS RESULTADOS SON: ")
print("La suma es: ",suma)
print("La cantidad de notas es: ",cant)
print("El promedio es: ",promedio_notas(pila_notas))