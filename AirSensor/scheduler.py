import schedule
import logging

def run(action):
    schedule.every(10).seconds.do(action)
    while True:
        try:
            schedule.run_pending()
        except KeyboardInterrupt:
            exit(0)
        # except:
            # logging.critical('Critical error occured')    


