1. When the subject (publisher) changes state, all its observers (subscribers) are notified automatically.

2. Promotes loose coupling → subject doesn’t need to know details of observers, only that they want updates.

3. Useful when multiple parts of a system need to react to the same event/change (e.g., UI updates, event systems, stock price updates, notifications).

4. It is a behavioural design pattern.

Real life analogy:
Analogy: YouTube subscriptions.

A YouTuber (subject) uploads a new video.

All the subscribers (observers) automatically get notified.

The YouTuber doesn’t care who the subscribers are — they just publish.