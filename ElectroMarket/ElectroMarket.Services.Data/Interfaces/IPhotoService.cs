using CloudinaryDotNet.Actions;
using ElectroMarket.Data.Models;
using Microsoft.AspNetCore.Http;

namespace ElectroMarket.Services.Data.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        Task<Photo> GetPhotoByIdAsync(string id);

        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
