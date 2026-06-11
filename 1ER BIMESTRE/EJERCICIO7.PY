#Una universidad debe registrar las notas de los estudiantes de una materia el programam debe permitir ingresar notas entre 1 al 100 las notas terminan cuando el usuario ingresa -1
#el programa debe mostrar cantidad de estudiantes aprobados(nota mayor a 51)
#cantidad de estudinates reprovados(nota menor a 51)
#promedio de las notas
contador_aprovados=0
contador_reprovados=0
promedio=0
suma_notas=0
a=0
while a!=-1:
    a=int(input("Ingrese la nota del estudiante:\n"))
    if 100>=a>=51:
        contador_aprovados=contador_aprovados+1
        print("Aprovados:",contador_aprovados)
        print("Reprovados",contador_reprovados)
    if 50>=a>=1 :
        contador_reprovados=contador_reprovados+1
        print("Reprovados",contador_reprovados)
        print("Aprovados:",contador_aprovados)
    suma_notas=suma_notas+a
    promedio=suma_notas/(contador_aprovados+contador_reprovados)
print("Aprovados:",contador_aprovados)
print("Reprovados",contador_reprovados)
print("El promedio de notas es",promedio)





