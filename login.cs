                if(API.AIO(KEY))
                {
                    //Code you want to do here on successful login
                    MessageBox.Show("VALID!");
                }
                else
                {
                    //Code you want to do here on failed login
                    MessageBox.Show("Your key does not exist!");
                    //Application.Exit(); // closes the application
                }
