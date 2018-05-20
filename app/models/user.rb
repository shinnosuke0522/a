class User < ApplicationRecord
  #has_many :chat_messages
  has_many :friendships_of_from_user, class_name: "Friendship", foreign_key: "from_user_id", dependent: :destroy
  has_many :friendships_of_to_user, class_name: "Friendship", foreign_key: "to_user_id", dependent: :destroy
  has_many :frineds_of_from_user, through: :friendships_of_from_user, source: "to_user"
  has_many :frineds_of_to_user, through: :friendships_of_to_user, source: "from_user"

  validates :name, presence: true, length: {maximum: 20}
  validates :email, presence: true, length: {maximum: 50},uniqueness: {case_sensitive: false}
  #has_secure_password
  #validates :password, presence: true, length:{minimum: 6}

  def friends
    frineds_of_from_user + friendships_of_to_user
  end
end