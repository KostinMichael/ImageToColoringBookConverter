using UI;

namespace Presenters{
    class MainPresenter : Presenter {
        private View Form;

        public MainPresenter(View form) {
            this.Form = form;
        }

        public void Run() {
            Form.Showy();
        }
    }
}
