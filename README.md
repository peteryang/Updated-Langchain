(1) conda create -n myenv


(2) conda init

(3) quit current bash and start bash again

(4) conda activate myenv

(5) Prepare the .env file

'''
OPENAI_API_KEY="sk-xxxxx"
LANGCHAIN_API_KEY="ls__xxxxx"
LANGCHAIN_PROJECT="Learning1"
GROQ_API_KEY="gsk_xxxx"
HUGGINGFACEHUB_API_TOKEN="hf_xxxx"
'''

(6) pip install -r requirements.txt

(7) refresh the browser or viscode if using codespace so that myenv can be selected from jupyter notebook