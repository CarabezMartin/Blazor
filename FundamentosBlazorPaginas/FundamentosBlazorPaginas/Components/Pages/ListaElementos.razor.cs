using Microsoft.AspNetCore.Components;

namespace FundamentosBlazorPaginas.Components.Pages
{
	public partial class ListaElementos:ComponentBase
	{
		private List<string> elementos = new List<string>();
		private string nuevoElemento;

		private void AgregarElemento()
		{
			if (!string.IsNullOrWhiteSpace(nuevoElemento))
			{
				elementos.Add(nuevoElemento);
				nuevoElemento = string.Empty;
			}

		}
	}
}
