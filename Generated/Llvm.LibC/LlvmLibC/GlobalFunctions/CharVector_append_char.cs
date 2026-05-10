using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector6appendEc")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::append(char)")]
internal static partial class CharVector_append_char
{
	public unsafe static bool Invoke(void* @this, sbyte new_char)
	{
		bool result = false;
		void* ptr = null;
		long num = 0L;
		sbyte b = new_char;
		unchecked
		{
			if ((ulong)((CharVector*)@this)->index >= (ulong)(((CharVector*)@this)->cur_buff_size - 2L))
			{
				((CharVector*)@this)->cur_buff_size *= 2L;
				if (((CharVector*)@this)->cur_str == &((CharVector*)@this)->local_buffer)
				{
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = malloc.Invoke(((CharVector*)@this)->cur_buff_size);
					int num2;
					if (ptr == null)
					{
						result = false;
						num2 = 1;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num);
						for (num = 0L; (ulong)num < (ulong)((CharVector*)@this)->index; num++)
						{
							sbyte b2 = ((sbyte*)((CharVector*)@this)->cur_str)[num];
							((sbyte*)ptr)[num] = b2;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num);
						((CharVector*)@this)->cur_str = ptr;
						num2 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &ptr);
					switch (num2)
					{
					case 0:
						break;
					case 1:
						goto IL_0198;
					default:
						throw null;
					}
				}
				else
				{
					((CharVector*)@this)->cur_str = realloc.Invoke(((CharVector*)@this)->cur_str, ((CharVector*)@this)->cur_buff_size);
					if (((CharVector*)@this)->cur_str == null)
					{
						result = false;
						goto IL_0198;
					}
				}
			}
			((sbyte*)((CharVector*)@this)->cur_str)[((CharVector*)@this)->index] = b;
			((CharVector*)@this)->index++;
			result = true;
			goto IL_0198;
		}
		IL_0198:
		return result;
	}
}
