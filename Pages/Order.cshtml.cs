using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Threading.Tasks;
using bakaryshop.Data;
using bakaryshop.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace bakaryshop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BakeryShopContext db;
        public OrderModel(BakeryShopContext db) => this.db = db;

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        public Product product { get; set; }

        [BindProperty,EmailAddress,Required(ErrorMessage ="Enter avalid Email Address"),Display(Name ="Enter Email Address")]
        public string OrderEmail { get; set; }

        [BindProperty,Required(ErrorMessage = "Please Supplay shipping address"),Display(Name ="Shipping Address")]
        public string OrderShipping { get; set; }

        public int OrderQuantity { get; set; }
        public async Task OnGetAsync()
        {
            product = await db.products.FindAsync(id);
        }
        public System.Net.ICredentialsByHost Credentials { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            product = await db.products.FindAsync(id);
            if(ModelState.IsValid)
            {
                var body = $"<p> Thank You , We recived your order for {OrderQuantity} of picese of {product.product_name}</p>" +
                         $"<p>Your Address is : {OrderEmail}</p>" +
                         $"<p> <b> Your Order will delivered without 60 minties</b></p>";
                using (var smtp = new SmtpClient())
                {
                    var googleCredntail = new NetworkCredntail()
                    {
                        username = "alaaosama519@gmail.com",
                        password = "alaaosama" 
                    };
                    smtp.Credentials = Credentials;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("alaaosama519@gmail.com");
                    await smtp.SendMailAsync(message);
                    smtp.UseDefaultCredentials = false;

                }
                    return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
        
    }
}
