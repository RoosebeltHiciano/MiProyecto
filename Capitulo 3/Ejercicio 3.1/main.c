#include <stdio.h>

/* N�mina.
El programa, al recibir los salarios de 15 profesores, obtiene el total de la n�mina de la universidad. */
int main(void)
{
    int I;
    float SAL, NOM;
    NOM = 0;
    for (I = 1; I <= 15; I++)
    {
        printf("Ingrese el salario del profesor %d: ", I);
        scanf("%f", &SAL);
        NOM = NOM + SAL;
    }
    printf("El total de la n�mina es: %.2f", NOM);

    return 0;
}
