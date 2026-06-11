sumar_venta = 0
Contar_venta = 0
Promedio=0
a=1
#Una farmacia necesita registrar las ventas realizada durante el dia el programa debe permitir ingresar el monto de cada venta hasta que el usuario escriba 0 para finalizar
#al terminar el programa de be mostra el total de ventas y la cantidad de ventas realizadas y por ultimo el promedio de las ventas


while a!=0:
    a=int(input("Ingrese una venta:\n"))
    sumar_venta=sumar_venta+a
    Contar_venta=Contar_venta+1
    Promedio=sumar_venta/Contar_venta
print("La suma de venta es:",sumar_venta)
print("La cantidad de venta es:",Contar_venta-1)
print("El promedio de venta es:",Promedio)