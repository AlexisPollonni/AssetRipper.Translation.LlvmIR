using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_append
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector6appendEc")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::append(char)")]
	public unsafe static bool Invoke(CharVector* @this, [NativeType("char")] sbyte new_char)
	{
		bool result = false;
		void* ptr = null;
		long num = 0L;
		sbyte b = new_char;
		unchecked
		{
			if ((ulong)@this->index >= (ulong)(@this->cur_buff_size - 2L))
			{
				@this->cur_buff_size *= 2L;
				if (@this->cur_str == &@this->local_buffer)
				{
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = malloc.Invoke(@this->cur_buff_size);
					int num2;
					if (ptr == null)
					{
						result = false;
						num2 = 1;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num);
						for (num = 0L; (ulong)num < (ulong)@this->index; num++)
						{
							sbyte b2 = ((sbyte*)@this->cur_str)[num];
							((sbyte*)ptr)[num] = b2;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num);
						@this->cur_str = ptr;
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
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
				}
				else
				{
					@this->cur_str = realloc.Invoke(@this->cur_str, @this->cur_buff_size);
					if (@this->cur_str == null)
					{
						result = false;
						goto IL_0198;
					}
				}
			}
			((sbyte*)@this->cur_str)[@this->index] = b;
			@this->index++;
			result = true;
			goto IL_0198;
		}
		IL_0198:
		return result;
	}
}
