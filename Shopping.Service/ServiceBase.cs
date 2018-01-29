using AutoMapper;
using Shopping.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service
{
    public class ServiceBase
    {
        public IMapper _mapper;
        public ShoppingContext _context;

        public ServiceBase(ShoppingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
