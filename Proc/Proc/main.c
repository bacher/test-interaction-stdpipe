#include <stdlib.h>
#include <stdio.h>

void main() {
	int *mas;
	int sum;
	unsigned char *cmas;
	int i;
	FILE *out;

	out = fopen("inputtest.txt", "w");
	mas = (int*)malloc(40 * sizeof(int));
	cmas = (unsigned char*)mas;

	for(i = 0; i < 40; ++i) {
		cmas[i] = (unsigned char)getc(stdin);
		fputc(cmas[i], out);
	}

	

	sum = 0;
	for(i = 0; i < 10; ++i) {
		sum += mas[i];
	}


	fprintf(out, "%d", sum);
	printf("%d", sum);

	fclose(out);
}