
# viewの<div id="messages">から受け取る
jQuery(document).on 'turbolinks:load', ->
  messages = $('#messages')
  if $('#messages').length > 0
    App.room = App.cable.subscriptions.create {channel:"RoomChannel", room_id: messages.data('room_id')},
#App.room = App.cable.subscriptions.create {channel:"RoomChannel", room_id: @messages.room_id},
      connected: ->
    # Called when the subscription is ready for use on the server

      disconnected: ->
    # Called when the subscription has been terminated by the server

      received: (data) ->
        $('#messages').append '<div>' + data['message'] + '</div>'

      speak: (message, room_id) ->
        @perform 'speak', message: message, room_id: @room.id

$(document).on 'keypress', '[data-behavior~=room_speaker]', (event) ->
  if event.keyCode is 13 # return = send
    App.room.speak event.target.value
    event.target.value = ''
    event.preventDefault()
