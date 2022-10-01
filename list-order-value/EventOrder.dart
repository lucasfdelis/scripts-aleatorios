// Script que ordena uma lista de objetos a partir do valor de uma propriedade
// Feita em Dart

class Event {
  final DateTime createdAt;
  final String description;

  Event({required this.description, required this.createdAt});
}

void printEventList(List<Event> events) {
  events.forEach((event) => print(
      'Event: ${event.description} - ${event.createdAt.toIso8601String()}'));
}

void main() {
  final today = DateTime.now();
  final yesterday = today.subtract(Duration(days: 1));
  final tomorrow = today.add(Duration(days: 1));

  final List<Event> events = [
    Event(description: 'Amanhã', createdAt: tomorrow),
    Event(description: 'Ontem', createdAt: yesterday),
    Event(description: 'Hoje', createdAt: today),
  ];

  print('Ordem Original');
  printEventList(events);

  print('---\nOrdem: Crescente');
  events.sort((a, b) => a.createdAt.isAfter(b.createdAt) ? 1 : -1);
  printEventList(events);

  print('---\nOrdem: Decrescente');
  events.sort((a, b) => a.createdAt.isAfter(b.createdAt) ? -1 : 1);
  printEventList(events);
}
