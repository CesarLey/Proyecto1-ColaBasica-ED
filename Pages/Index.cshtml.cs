using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private static Queue<int> cola = new Queue<int>();
        private const int CAPACIDAD_MAXIMA = 10;
        // Controla si la visualización completa de la cola está visible.
        private static bool mostrarVisible = false;

        public string EstadoCola { get; set; } = string.Empty;
        public int TamanoCola { get; set; }
        public bool EstaVacia { get; set; }
        public bool EstaLlena { get; set; }
        public string Resultado { get; set; } = string.Empty;
    public List<int> ElementosCola { get; set; } = new List<int>();
    // Banderas UI mínimas para que Peek muestre sólo el frente o sólo el final
    public bool PeekFrenteVisible { get; set; } = false;
    public bool PeekFinalVisible { get; set; } = false;

        [BindProperty]
        public int Valor { get; set; }

    // Propiedad de solo lectura para la vista (refleja el campo estático)
    public bool MostrarVisible { get => mostrarVisible; }

        public void OnGet()
        {
            ActualizarEstado();
            // Si la vista está en modo "mostrar", cargar elementos; si no, mantener la lista actual (puede venir de Peek)
            if (mostrarVisible)
            {
                ElementosCola = cola.ToList();
            }
        }

        public IActionResult OnPostEncolar()
        {
            if (cola.Count >= CAPACIDAD_MAXIMA)
            {
                Resultado = $"❌ Error: Cola llena (capacidad máxima: {CAPACIDAD_MAXIMA})";
            }
            else
            {
                // Insertar el nuevo valor al frente de la cola (push front)
                var actuales = cola.ToArray();
                var nuevos = new int[actuales.Length + 1];
                nuevos[0] = Valor;
                System.Array.Copy(actuales, 0, nuevos, 1, actuales.Length);
                cola = new Queue<int>(nuevos);
                Resultado = $"✅ Encolado al frente: {Valor}";
            }
            ActualizarEstado();
            // Limpiar banderas de peek para evitar que una vista de peek previa persista
            PeekFrenteVisible = false;
            PeekFinalVisible = false;
            // No cambiar la visibilidad: solo actualizar la lista si está en modo mostrar
            ElementosCola = mostrarVisible ? cola.ToList() : new List<int>();
            return Page();
        }

        public IActionResult OnPostDesencolar()
        {
            if (cola.Count == 0)
            {
                Resultado = "❌ Error: Cola vacía";
            }
            else
            {
                int valor = cola.Dequeue();
                Resultado = $"► Desencolado: {valor}";
            }
            ActualizarEstado();
            PeekFrenteVisible = false;
            PeekFinalVisible = false;
            ElementosCola = mostrarVisible ? cola.ToList() : new List<int>();
            return Page();
        }

        public IActionResult OnPostPeek()
        {
            if (cola.Count == 0)
            {
                Resultado = "❌ Error: Cola vacía";
                ElementosCola = new List<int>();
                ActualizarEstado();
                return Page();
            }
            int frente = cola.Peek();
            Resultado = $"👁️ Frente de la cola: {frente}";
            ActualizarEstado();
            // Mostrar sólo el frente visualmente
            mostrarVisible = false;
            PeekFrenteVisible = true;
            PeekFinalVisible = false;
            ElementosCola = new List<int> { frente };
            return Page();
        }

        public IActionResult OnPostPeekFinal()
        {
            if (cola.Count == 0)
            {
                Resultado = "❌ Error: Cola vacía";
                ElementosCola = new List<int>();
                ActualizarEstado();
                return Page();
            }
            int[] arr = cola.ToArray();
            int ultimo = arr[arr.Length - 1];
            Resultado = $"👁️ Final de la cola: {ultimo}";
            ActualizarEstado();
            // Mostrar sólo el final visualmente
            mostrarVisible = false;
            PeekFinalVisible = true;
            PeekFrenteVisible = false;
            ElementosCola = new List<int> { ultimo };
            return Page();
        }

        public IActionResult OnPostMostrar()
        {
            // Alternar la visibilidad de la representación completa de la cola
            mostrarVisible = !mostrarVisible;
            if (mostrarVisible)
            {
                ElementosCola = cola.ToList();
                // Si mostramos toda la cola, limpiamos banderas de peek
                PeekFrenteVisible = false;
                PeekFinalVisible = false;
                Resultado = $"📋 Mostrando cola ({ElementosCola.Count} elementos)";
            }
            else
            {
                ElementosCola = new List<int>();
                Resultado = "📋 Ocultando visualización de la cola";
            }
            ActualizarEstado();
            return Page();
        }

        public IActionResult OnPostInvertir()
        {
            if (cola.Count == 0)
            {
                Resultado = "📋 Cola vacía: []";
            }
            else if (cola.Count == 1)
            {
                Resultado = "📋 Cola con 1 elemento (no se invierte)";
            }
            else
            {
                int[] elementos = cola.ToArray();
                System.Array.Reverse(elementos);
                cola = new Queue<int>(elementos);
                Resultado = "🔁 Cola invertida";
            }
            ActualizarEstado();
            PeekFrenteVisible = false;
            PeekFinalVisible = false;
            ElementosCola = mostrarVisible ? cola.ToList() : new List<int>();
            return Page();
        }

        public IActionResult OnPostLimpiar()
        {
            int cantidad = cola.Count;
            cola.Clear();
            Resultado = $"🧹 Cola limpiada ({cantidad} elementos eliminados)";
            ActualizarEstado();
            PeekFrenteVisible = false;
            PeekFinalVisible = false;
            ElementosCola = mostrarVisible ? cola.ToList() : new List<int>();
            return Page();
        }

        private void ActualizarEstado()
        {
            TamanoCola = cola.Count;
            EstaVacia = cola.Count == 0;
            EstaLlena = cola.Count >= CAPACIDAD_MAXIMA;
            EstadoCola = EstaVacia ? "Vacía" : EstaLlena ? "Llena" : "Activa";
            // No sobrescribimos ElementosCola aquí: se controla por cada handler
        }
    }
}
