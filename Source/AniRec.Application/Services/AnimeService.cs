using AniRec.Application.DTOs;
using AniRec.Application.Interfaces;
using AniRec.Domain.Entities;
using AniRec.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Application.Services {
    public class AnimeService : IService<AnimeDto> {

        private readonly IUnitOfWork _unitOfWork;

        public AnimeService(IUnitOfWork unitOfWork) { 
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(AnimeDto entity) {
            var anime = new Anime();
            await _unitOfWork.AnimeRepository.AddAsync(anime);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAsync(int id) {
            await _unitOfWork.AnimeRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();  
        }

        public async Task<IEnumerable<AnimeDto>> GetAllAsync() {
            var animes = await _unitOfWork.AnimeRepository.GetAllAsync();
            return animes.Select(anime => new AnimeDto { });
        }

        public async Task<AnimeDto> GetByIdAsync(int id) {
            var anime = await _unitOfWork.AnimeRepository.GetByIdAsync(id);
            return new AnimeDto { };
        }

        public async Task UpdateAsync(AnimeDto entity) {
            var anime = new Anime { };
            await _unitOfWork.AnimeRepository.UpdateAsync(anime);
            await _unitOfWork.CompleteAsync();
        }
    }
}
