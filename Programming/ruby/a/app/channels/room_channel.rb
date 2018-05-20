class RoomChannel < ApplicationCable::Channel
  def subscribed
     stream_from "room_channel_#{params['room_id']}"
  end

  def unsubscribed
    # Any cleanup needed when channel is unsubscribed
  end

  def speak(data)
  	#ApplicationCable.server.broadcast 'room_channel', message: data['message']
  	Message.create! body: data['message'], room_id: data['room_id']
  end
end
