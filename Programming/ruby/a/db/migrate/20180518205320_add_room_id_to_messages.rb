class AddRoomIdToMessages < ActiveRecord::Migration[5.2]
  def change
  	add_column :messages, :room_id, :string
  end
end
