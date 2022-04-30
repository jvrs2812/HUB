using Microsoft.AspNetCore.Mvc;

public class GetRoutes : ControllerBase
{
    private WebServiceProvider service;
    public GetRoutes([FromServices] WebServiceProvider service)
    {
        this.service = service;
    }

    [HttpGet("api1/{provedor}/product/{id}")]
    public async Task<ActionResult> GetProduct(
        [FromRoute] string provedor,
        [FromRoute] string id,
        [FromServices] ModelProductBase model
    )
    {
        try
        {
            ProviderBaseService providerBase = service.setProvider(provedor);

            model = await providerBase.Product(id);

            return Ok(new ResponseApi<ModelProductBase>(model));
        }
        catch (NotImplementedException)
        {
            return BadRequest(new ResponseApi<ModelProductBase>("Metodo não implementado para esse provedor"));
        }
        catch (NotFoundException err)
        {
            return NotFound(new ResponseApi<ModelProductBase>(err.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, new ResponseApi<ModelProductBase>("Erro interno do servidor get produtos " + provedor + "  contate o administrador"));
        }

    }
}
