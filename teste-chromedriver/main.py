from selenium import webdriver
import chromedriver_autoinstaller

print("oi")
chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
print("oi 2")                                  # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

driver = webdriver.Chrome()
driver.get("http://www.python.org")