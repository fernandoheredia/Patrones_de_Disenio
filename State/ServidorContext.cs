 public class ServidorContext
    {
        private ServerState state;

        public ServerState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void AtenderSolicitud()
        {
            state.Respuesta();
        }
    }