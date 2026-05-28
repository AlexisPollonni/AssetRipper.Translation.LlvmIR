using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_append
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector6appendEc")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::append(char)")]
	public unsafe static bool Invoke([MangledName("this")] CharVector* This, [MangledName("new_char")][NativeType("char")] sbyte New_char)
	{
		bool result = false;
		void* ptr = null;
		long num = 0L;
		sbyte b = New_char;
		unchecked
		{
			if ((ulong)This->Index >= (ulong)(This->Cur_buff_size - 2L))
			{
				This->Cur_buff_size *= 2L;
				if (This->Cur_str == &This->Local_buffer)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = Malloc.Invoke(This->Cur_buff_size);
					int num2;
					if (ptr == null)
					{
						result = false;
						num2 = 1;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num);
						for (num = 0L; (ulong)num < (ulong)This->Index; num++)
						{
							sbyte b2 = ((sbyte*)This->Cur_str)[num];
							((sbyte*)ptr)[num] = b2;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num);
						This->Cur_str = ptr;
						num2 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &ptr);
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
					This->Cur_str = Realloc.Invoke(This->Cur_str, This->Cur_buff_size);
					if (This->Cur_str == null)
					{
						result = false;
						goto IL_0198;
					}
				}
			}
			((sbyte*)This->Cur_str)[This->Index] = b;
			This->Index++;
			result = true;
			goto IL_0198;
		}
		IL_0198:
		return result;
	}
}
