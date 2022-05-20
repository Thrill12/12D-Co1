## Digital Signature Process

Digital signatures are used to confirm the identity of sender // that message as sent by A // to detect if message has been tampered with / changed

- Message is hashed/digest is created // value is calculated from message
- Hash encrypted with A’s public key
- Encrypted hash is known as the digital signature
- Digital signature is appended to message
- A encrypts message and signature with B’s public key
- B decrypts message and signature with B’s private key
- B decrypts digital signature using A’s public key to reveal hash
- B reproduces/recalculates hash from received message
- If received hash matches reproduced hash then message has not been tampered with // identity of sender is authenticated
