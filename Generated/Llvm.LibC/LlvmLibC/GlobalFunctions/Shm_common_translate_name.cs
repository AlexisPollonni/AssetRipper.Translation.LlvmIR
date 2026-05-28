using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Shm_common_translate_name
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common14translate_nameENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::shm_common::translate_name(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_hnriuf* Agg_result, [MangledName("name.coerce0")] void* Name, [MangledName("name.coerce1")] long Offset)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		long num = 0L;
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view4 = default(Cpp_string_view);
		Cpp_array_knc3mr cpp_array_knc3mr = default(Cpp_array_knc3mr);
		unchecked
		{
			*(void**)(&cpp_string_view) = Name;
			((long*)(&cpp_string_view))[1] = Offset;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = String_view_find_first_not_of.Invoke(&cpp_string_view, 47, 0L);
			if (num == -1L)
			{
				Errno_Assignment.Invoke(Libc_errno.Pointer, 22);
				Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				Struct_kqhe8i struct_kqhe8i = String_view_substr.Invoke(&cpp_string_view, num, -1L);
				Cpp_string_view* num2 = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &cpp_string_view2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
				if ((ulong)String_view_size.Invoke(&cpp_string_view) > 255uL)
				{
					Errno_Assignment.Invoke(Libc_errno.Pointer, 36);
					Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
				}
				else
				{
					String_view_Constructor.Invoke(&cpp_string_view3, Str_111.Pointer);
					if (!String_view_Equals.Invoke(&cpp_string_view, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]))
					{
						String_view_Constructor.Invoke(&cpp_string_view4, Str_1_112.Pointer);
						if (!String_view_Equals.Invoke(&cpp_string_view, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]) && !String_view_contains.Invoke(&cpp_string_view, 47))
						{
							Llvm_lifetime_start_p0.Invoke(265L, &cpp_array_knc3mr);
							Llvm_memset_p0_i64.Invoke(&cpp_array_knc3mr, -86, 265L, isVolatile: false);
							Inline_memcpy.Invoke(Array_char_265ul_data.Invoke(&cpp_array_knc3mr), String_view_data.Invoke(Shm_common_SHM_PREFIX.Pointer), String_view_size.Invoke(Shm_common_SHM_PREFIX.Pointer));
							Inline_memcpy.Invoke((byte*)Array_char_265ul_data.Invoke(&cpp_array_knc3mr) + String_view_size.Invoke(Shm_common_SHM_PREFIX.Pointer), String_view_data.Invoke(&cpp_string_view), String_view_size.Invoke(&cpp_string_view));
							*(sbyte*)Array_char_265ul_Index.Invoke(&cpp_array_knc3mr, String_view_size.Invoke(Shm_common_SHM_PREFIX.Pointer) + String_view_size.Invoke(&cpp_string_view)) = 0;
							Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result, &cpp_array_knc3mr);
							Llvm_lifetime_end_p0.Invoke(265L, &cpp_array_knc3mr);
							goto IL_0234;
						}
					}
					Errno_Assignment.Invoke(Libc_errno.Pointer, 22);
					Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
				}
			}
			goto IL_0234;
		}
		IL_0234:
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
