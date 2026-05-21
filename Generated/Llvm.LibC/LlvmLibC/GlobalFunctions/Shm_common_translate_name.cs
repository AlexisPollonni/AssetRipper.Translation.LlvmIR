using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Shm_common_translate_name
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common14translate_nameENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::shm_common::translate_name(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_hnriuf* Agg_result, [MangledName("name.coerce0")] void* Name, [MangledName("name.coerce1")] long Offset)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long num = 0L;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view4 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_array_knc3mr llvm_libc_20_1_2_cpp_array_knc3mr = default(Llvm_libc_20_1_2_cpp_array_knc3mr);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Name;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Offset;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = String_view_find_first_not_of.Invoke(&llvm_libc_20_1_2_cpp_string_view, 47, 0L);
			if (num == -1L)
			{
				Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 22);
				Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
				Struct_kqhe8i struct_kqhe8i = String_view_substr.Invoke(&llvm_libc_20_1_2_cpp_string_view, num, -1L);
				Llvm_libc_20_1_2_cpp_string_view* num2 = &llvm_libc_20_1_2_cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&llvm_libc_20_1_2_cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view, &llvm_libc_20_1_2_cpp_string_view2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
				if ((ulong)String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view) > 255uL)
				{
					Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 36);
					Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
				}
				else
				{
					String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view3, Str_111.Pointer);
					if (!String_view_Equals.Invoke(&llvm_libc_20_1_2_cpp_string_view, *(void**)(&llvm_libc_20_1_2_cpp_string_view3), ((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1]))
					{
						String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view4, Str_1_112.Pointer);
						if (!String_view_Equals.Invoke(&llvm_libc_20_1_2_cpp_string_view, *(void**)(&llvm_libc_20_1_2_cpp_string_view4), ((long*)(&llvm_libc_20_1_2_cpp_string_view4))[1]) && !String_view_contains.Invoke(&llvm_libc_20_1_2_cpp_string_view, 47))
						{
							Llvm_lifetime_start_p0.Invoke(265L, &llvm_libc_20_1_2_cpp_array_knc3mr);
							Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_knc3mr, -86, 265L, isVolatile: false);
							Llvm_libc_20_1_2_inline_memcpy.Invoke(Array_char_265ul_data.Invoke(&llvm_libc_20_1_2_cpp_array_knc3mr), String_view_data.Invoke(Llvm_libc_20_1_2_shm_common_SHM_PREFIX.Pointer), String_view_size.Invoke(Llvm_libc_20_1_2_shm_common_SHM_PREFIX.Pointer));
							Llvm_libc_20_1_2_inline_memcpy.Invoke((byte*)Array_char_265ul_data.Invoke(&llvm_libc_20_1_2_cpp_array_knc3mr) + String_view_size.Invoke(Llvm_libc_20_1_2_shm_common_SHM_PREFIX.Pointer), String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view));
							*(sbyte*)Array_char_265ul_Index.Invoke(&llvm_libc_20_1_2_cpp_array_knc3mr, String_view_size.Invoke(Llvm_libc_20_1_2_shm_common_SHM_PREFIX.Pointer) + String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view)) = 0;
							Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_cpp_array_knc3mr);
							Llvm_lifetime_end_p0.Invoke(265L, &llvm_libc_20_1_2_cpp_array_knc3mr);
							goto IL_0234;
						}
					}
					Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 22);
					Optional_cpp_array_char_265ul_Constructor.Invoke(Agg_result);
				}
			}
			goto IL_0234;
		}
		IL_0234:
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
